using FoodLog.BLL;
using Microsoft.AspNetCore.Mvc;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.DAL.Controllers
{
    public class ProdCatsController : Controller
    {
        private readonly UnitOfWork _uow;
        public ProdCatsController(UnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductCategory> prodCats = await _uow.ProdCatRepository.GetEntity();
            return View(prodCats);
        }


        public async Task<IActionResult> Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ProductCategory product)
        {
            await _uow.ProdCatRepository.Insert(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid prodGuid)
        {
            await _uow.ProdCatRepository.Delete(prodGuid);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(Guid prodGuid) => View(await _uow.ProdCatRepository.GetEntity(prodGuid));

        [HttpPost]
        public async Task<IActionResult> Update(ProductCategory product)
        {
            await _uow.ProdCatRepository.Update(product);
            return RedirectToAction(nameof(Index));
        }

    }
}
