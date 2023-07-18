using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.WebMVC.Controllers;

public class CategoriesController :Controller
{
    private readonly FoodLogDbContext _db;
    public CategoriesController(FoodLogDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        List<Category> categories = await _db.Categories.ToListAsync();
        return View(categories);

    }
    public async Task<IActionResult> Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        await _db.Categories.AddAsync(category);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Delete(Guid catGuid)
    {
        Category? category = await _db.Categories.FirstOrDefaultAsync(x => x.Guid == catGuid);
        if (category is null)
            return RedirectToAction(nameof(Index));

        _db.Set<Category>().Remove(category);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}
