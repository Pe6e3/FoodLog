using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.DAL.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FoodLogDbContext _db;
        public ProductsController(FoodLogDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _db.Products.OrderByDescending(x=>x.Caloriers).ToListAsync();
            return View(products);
        }


        public async Task<IActionResult> Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _db.Products.AddAsync(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid prodGuid)
        {
            Product? product = await _db.Products.FirstOrDefaultAsync(x => x.Guid == prodGuid);
               if (product is null)
                return RedirectToAction(nameof(Index));

            _db.Set<Product>().Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
