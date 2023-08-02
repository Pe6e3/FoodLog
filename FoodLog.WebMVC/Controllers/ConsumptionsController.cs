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
    public async Task<IActionResult> IndexPartial()
    {
        IEnumerable<Consumption> consumptions = await _uow.ConsumptionRepository.GetEntity("Product");
        return PartialView("_ConsumptionTable", consumptions);
    }



    public async Task<IActionResult> Create()
    {
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Create(Consumption consumption)
    {
        await CalculateConsume(consumption);
        await _uow.ConsumptionRepository.Insert(consumption);
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return RedirectToAction(nameof(Create));
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
        IEnumerable<StorageProduct> storage = await _uow.StorageProductRepository.FilterProducts(consumption.ProductGuid);
        if (storage.Sum(s => s.CurrentWeight) < consumptionWeight)
        {
            ModelState.AddModelError("", "Недостаточно продукта на складе для потребления.");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        foreach (StorageProduct storageProduct in storage)
        {
            double currentWeight = storageProduct.CurrentWeight;
            if (consumptionWeight > 0)
            {
                await WriteOffTrash(storageProduct, consumption, Math.Min(consumptionWeight, storageProduct.CurrentWeight));
                storageProduct.CurrentWeight -= consumptionWeight;
                consumptionWeight = Math.Max(consumptionWeight - currentWeight, 0);
                if (storageProduct.CurrentWeight <= 0)
                    await _uow.StorageProductRepository.Delete(storageProduct);  // Если вес потребления больше, чем в данной строке на складе (списываем строку полностью)
                else await _uow.StorageProductRepository.Update(storageProduct); // Если вес потребления меньше, чем в данной строке на складе (списываем строку частично)
            }
        }
        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storage, storageLineVMs);
        return PartialView("_StorageTable", storageLineVMs);
    }
    private async Task WriteOffTrash(StorageProduct storageProduct, Consumption consumption, double consumeWeight)
    {
        Trash trash = new Trash
        {
            ProductGuid = storageProduct.ProductGuid,
            WriteOffReasonGuid = await _uow.ReasonRepository.ConsumeReason(),
            Date = DateTime.Now,
            TrashWeight = consumeWeight * consumption.TrashPercentage / 100,
            TrashCost = storageProduct.CurrentCost * consumption.TrashWeight / 1000,
            GuidOfPurchase = storageProduct.GuidOfPurchase
        };
        await _uow.TrashRepository.Insert(trash);
    }



    public async Task<IActionResult> StorageProductsPartial()
    {
        IEnumerable<StorageProduct> storageProducts = await _uow.StorageProductRepository.GetEntity("Product");
        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storageProducts, storageLineVMs);

        return PartialView("StorageProductsPartial", storageLineVMs);
    }



}
