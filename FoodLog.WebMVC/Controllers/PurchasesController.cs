using FoodLog.BLL;
using Microsoft.AspNetCore.Mvc;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FoodLog.DAL.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public PurchasesController(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index() => View(await _uow.PurchaseRepository.GetEntity(Include: "Product"));


        public async Task<IActionResult> Create()
        {
            ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Purchase purchase)
        {
            if (purchase.Cost == 0 && purchase.Price != 0)
                purchase.Cost = Math.Round((purchase.Price * purchase.Weight / 1000), 1);
            if (purchase.Cost != 0 && purchase.Price != 0 && purchase.Cost != Math.Round((purchase.Price * purchase.Weight / 1000), 1))
            {
                ModelState.AddModelError(string.Empty, "Стоимость не равна цене умноженной на вес");
                ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
                return View(purchase);
            }
            if (purchase.Cost != 0 && purchase.Price == 0)
                purchase.Price = Math.Round(purchase.Cost / (purchase.Weight / 1000), 1);
            await _uow.PurchaseRepository.Insert(purchase);

            // добавляем купленный товар на склад
            var storageProduct = new StorageProduct();
            storageProduct.GuidOfPurchase = purchase.Guid;
            storageProduct.ProductGuid = purchase.ProductGuid;
            storageProduct.CurrentWeight = purchase.Weight;
            storageProduct.CurrentCost = purchase.Cost;
            await _uow.StorageProductRepository.Insert(storageProduct);

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(Guid purchaseGuid)
        {
            await _uow.PurchaseRepository.DeletePurchase(purchaseGuid);
            return RedirectToAction(nameof(Index));

        }

    }
}
