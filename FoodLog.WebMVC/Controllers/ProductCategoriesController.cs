using FoodLog.BLL;
using Microsoft.AspNetCore.Mvc;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.DAL.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly UnitOfWork _uow;
        public ProductCategoriesController(UnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductCategory> prodCats = await _uow.ProdCatRepository.GetEntity("Product", "Category");
            return View(prodCats);
        }

        public async Task<IActionResult> IndexPartial(Guid prodGuid)
        {
            IEnumerable<ProductCategory> prodCats = await _uow.ProdCatRepository.GetProdCatsByProdGuid(prodGuid);
            return PartialView("_Categories", prodCats);
        }

        public async Task<IActionResult> CreatePartial(Guid prodGuid)
        {
            ViewBag.ProdGuid = prodGuid;
            ViewBag.AllCategories = await _uow.CategoryRepository.GetEntity();
            ViewBag.ProdCats = await _uow.ProdCatRepository.GetProdCatsByProdGuid(prodGuid);

            return PartialView("_CreateCategory");
        }

        public async Task<IActionResult> Create(Guid prodGuid)
        {
            ViewBag.ProdGuid = prodGuid;
            Product product = await _uow.ProductRepository.GetEntity(prodGuid);

            ViewBag.ProdName = product.Name;
            ViewBag.AllCategories = await _uow.CategoryRepository.GetEntity();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCategory prodCat)
        {
            await _uow.ProdCatRepository.Insert(prodCat);
            return RedirectToAction("Update", "Products", new { prodGuid = prodCat.ProductGuid });
        }

        public async Task<IActionResult> Delete(Guid prodCatGuid)
        {
            Guid prodGuid = await _uow.ProdCatRepository.GetProdGuid(prodCatGuid);
            await _uow.ProdCatRepository.Delete(prodCatGuid);
            return RedirectToAction("Update", "Products", new { prodGuid = prodGuid });

        }

        public async Task<IActionResult> Update(Guid prodCatGuid) => View(await _uow.ProdCatRepository.GetEntity(prodCatGuid));

        [HttpPost]
        public async Task<IActionResult> Update(ProductCategory prodCat)
        {
            await _uow.ProdCatRepository.Update(prodCat);
            return RedirectToAction(nameof(Index));
        }

    }
}
