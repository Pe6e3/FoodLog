using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.Models;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodLog.WebMVC.Controllers;

public class ConsumptionsController : Controller
{
    private readonly UnitOfWork _uow;
    private readonly IMapper _mapper;

    public ConsumptionsController(UnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return View();
    }
    public async Task<IActionResult> IndexPartial(int count = 7)
    {
        IEnumerable<Consumption> consumptions = await _uow.ConsumptionRepository.GetConsumptions(count);
        return PartialView("_ConsumptionTable", consumptions);
    }



    public async Task<IActionResult> Create()
    {
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return View(nameof(Index));
    }


    [HttpPost]
    public async Task<IActionResult> Create(Consumption consumption)
    {
        await CalculateConsume(consumption);

        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid consumeGuid)
    {
        await _uow.ConsumptionRepository.Delete(consumeGuid);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> CalculateConsume(Consumption consumption)
    {
        double consumptionWeight = consumption.Brutto;
        IEnumerable<StorageProduct> storage = await _uow.StorageProductRepository.FilterProducts(consumption.ProductGuid);  // Получаем все строки с данным продуктом
        if (storage.Sum(s => s.CurrentWeight) < consumptionWeight)                                                          // Проверяем: если хотим употребить больше чем есть, то вывести ошибку
        {
            ModelState.AddModelError("", "Недостаточно продукта на складе для потребления.");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        foreach (StorageProduct storageProduct in storage)                                      // Перебираем каждую строку с потребляемым продуктом сверху вниз
        {
            double lineWeight = storageProduct.CurrentWeight;                                   // Вес продукта, который указан в строке
            if (consumptionWeight > 0)                                                          // Вес продукта, который собираемся съесть
            {
                double tempWeight = consumptionWeight;  // локальная переменная, которая не изменится до того, как начнет выполнятся асинхронный метод (в отличие от consumptionWeight)
                await WriteOffTrash(storageProduct, consumption.TrashPercentage, Math.Min(tempWeight, storageProduct.CurrentWeight));
                await WriteOffStorage(storageProduct, Math.Min(tempWeight, lineWeight));
                await AddConsume(storageProduct.GuidOfPurchase, Math.Min(tempWeight, lineWeight) * (1 - (consumption.TrashPercentage / 100)));
                consumptionWeight -= lineWeight;                                                // Вычитаем из общего веса, который необходимо употребить, тот вес, который только что списали
            }
        }
        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storage, storageLineVMs);
        return PartialView("_StorageTable", storageLineVMs);
    }
    private async Task WriteOffTrash(StorageProduct storageProduct, double trashPercentage, double consumeWeight)
    {
        Purchase purchase = await _uow.PurchaseRepository.GetEntity(storageProduct.GuidOfPurchase);

        Trash trash = new Trash();
        trash.ProductGuid = storageProduct.ProductGuid;
        trash.WriteOffReasonGuid = await _uow.ReasonRepository.ConsumeReason();
        trash.Date = DateTime.Now;
        trash.TrashWeight = consumeWeight * trashPercentage / 100;
        trash.TrashCost = purchase.Price * trash.TrashWeight / 1000;
        trash.GuidOfPurchase = storageProduct.GuidOfPurchase;
        await _uow.TrashRepository.Insert(trash);
    }

    private async Task WriteOffStorage(StorageProduct storageProduct, double brutto)
    {
        if (storageProduct.CurrentWeight == brutto)
        {
            await _uow.StorageProductRepository.Delete(storageProduct);
            return;
        }
        storageProduct.CurrentWeight -= brutto;
        await _uow.StorageProductRepository.Update(storageProduct);
    }

    private async Task AddConsume(Guid purchaseGuid, double netto)
    {
        Consumption consumption = new Consumption()
        {
            Guid = new Guid(),
            Date = DateTime.Now,
            GuidOfPurchase = purchaseGuid,
            ProductGuid = await _uow.ProductRepository.GetProdGuidByPurchaseGuid(purchaseGuid),
            Netto = netto
        };
        await _uow.ConsumptionRepository.Insert(consumption);
    }



    public async Task<IActionResult> StorageProductsPartial()
    {
        IEnumerable<StorageProduct> storageProducts = await _uow.StorageProductRepository.GetEntity("Product", "Purchase");
        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storageProducts, storageLineVMs);

        return PartialView("StorageProductsPartial", storageLineVMs);
    }



}
