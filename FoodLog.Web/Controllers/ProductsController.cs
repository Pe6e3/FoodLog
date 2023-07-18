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
            List<Product> products = await _db.Products.ToListAsync();

            return View(products);
        }
    }
}
