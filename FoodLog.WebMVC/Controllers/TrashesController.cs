﻿using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodLog.WebMVC.Controllers
{
    public class TrashesController : Controller
    {
        private readonly UnitOfWork _uow;

        public TrashesController(UnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Trash> trashes = await _uow.TrashRepository.GetEntity();
            return View(trashes);
        }


        public async Task<IActionResult> Delete(Guid trashGuid)
        {
            await _uow.TrashRepository.Delete(trashGuid);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Trash trash)
        {
            await _uow.TrashRepository.Insert(trash);
            return RedirectToAction(nameof(Index));
        }

    }
}
