using FoodLog.BLL;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.WebMVC.Controllers;

public class CategoriesController : Controller
{
    private readonly UnitOfWork _uow;
    public CategoriesController(UnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<Category> categories = await _uow.CategoryRepository.GetEntity();
        return View(categories);
    }
    public async Task<IActionResult> Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        await _uow.CategoryRepository.Insert(category);
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Delete(Guid catGuid)
    {
        await _uow.CategoryRepository.Delete(catGuid);
        return RedirectToAction(nameof(Index));
    }

}
