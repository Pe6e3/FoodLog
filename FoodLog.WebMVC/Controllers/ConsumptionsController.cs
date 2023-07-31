using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        IEnumerable<Consumption> consumptions = await _uow.ConsumptionRepository.GetEntity("Product");
        return View(consumptions);
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
        IEnumerable<StorageProduct> storage = await _uow.StorageProductRepository.FilterProducts(consumption.ProductGuid);
        double consumeWeigth = consumption.Brutto;

        foreach (StorageProduct storageProduct in storage)
        {
            if (consumeWeigth > storageProduct.CurrentWeight)
            {
                consumeWeigth -= storageProduct.CurrentWeight;
                Trash trash = new Trash();
                trash.ProductGuid = storageProduct.ProductGuid;
                trash.WriteOffReasonGuid = await _uow.ReasonRepository.ConsumeReason();
                trash.TrashWeight = consumption.TrashWeight;
                trash.Date = DateTime.Now;
                trash.TrashCost = storageProduct.CurrentCost * consumption.TrashWeight / 1000;
                await _uow.TrashRepository.Insert(trash);
                await _uow.StorageProductRepository.Delete(storageProduct);
            }
            else
            {
                if (consumeWeigth > 0)
                {
                    storageProduct.CurrentWeight -= consumeWeigth;
                    Trash trash = new Trash();
                    trash.ProductGuid = storageProduct.ProductGuid;
                    trash.WriteOffReasonGuid = await _uow.ReasonRepository.ConsumeReason();
                    trash.TrashWeight = consumption.TrashWeight;
                    trash.Date = DateTime.Now;
                    trash.TrashCost = storageProduct.CurrentCost * storageProduct.CurrentWeight / 1000;
                    await _uow.TrashRepository.Insert(trash);
                    consumeWeigth = 0;

                    await _uow.StorageProductRepository.Update(storageProduct);
                    if (storageProduct.CurrentWeight == 0)
                        await _uow.StorageProductRepository.Delete(storageProduct);

                }
            }
        }

        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storage, storageLineVMs);
        return PartialView("_StorageTable", storageLineVMs);
    }




    public async Task<IActionResult> StorageProductsPartial()
    {
        IEnumerable<StorageProduct> storageProducts = await _uow.StorageProductRepository.GetEntity("Product");
        IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
        _mapper.Map(storageProducts, storageLineVMs);

        return PartialView("StorageProductsPartial", storageLineVMs);
    }



}
