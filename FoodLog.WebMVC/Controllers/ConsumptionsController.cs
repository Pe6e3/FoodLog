using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
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
    public async Task<IActionResult> Create()
    {
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Consumption consumption)
    {
        await _uow.ConsumptionRepository.Insert(consumption);
        ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid consumGuid)
    {
        await _uow.ConsumptionRepository.Delete(consumGuid);
        return RedirectToAction(nameof(Index));
    }
}
