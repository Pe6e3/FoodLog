using FoodLog.BLL;
using Microsoft.AspNetCore.Mvc;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.DAL.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly UnitOfWork _uow;
        public PurchasesController(UnitOfWork uow)
        {
            _uow = uow;
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
                purchase.Cost = purchase.Price * purchase.Weight / 1000;
            if (purchase.Cost != 0 && purchase.Price != 0 && purchase.Cost != (purchase.Price * purchase.Weight / 1000))
            {
                ModelState.AddModelError(string.Empty, "Стоимость не равна цене умноженной на вес");
                ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
                return View(purchase);
            }
            if (purchase.Cost != 0 && purchase.Price == 0)
                purchase.Price = purchase.Cost / (purchase.Weight / 1000);
            await _uow.PurchaseRepository.Insert(purchase);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(Guid purchaseGuid)
        {
            await _uow.PurchaseRepository.Delete(purchaseGuid);
            return RedirectToAction(nameof(Index));
        }

    }
}
