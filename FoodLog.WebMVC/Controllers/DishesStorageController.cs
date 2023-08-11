using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodLog.WebMVC.Controllers
{
    public class DishStorageesController : Controller
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public DishStorageesController(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<DishStorage> storageDishes = await _uow.DishStorageRepository.GetStorage();
            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storageDishes, storageLineVMs);

            return View(storageLineVMs);
        }

        public async Task<IActionResult> IndexPartial(string filter = "")
        {
            IEnumerable<DishStorage> storageDishes = await _uow.DishStorageRepository.GetEntity("Dish", "Purchase");
            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storageDishes, storageLineVMs);
            ViewBag.Filter = filter;

            return PartialView("_StorageTable", storageLineVMs);
        }



        public async Task<IActionResult> Create()
        {
            ViewBag.AllDishes = await _uow.DishStorageRepository.GetEntity();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StorageLineVM storageLineVM)
        {
            var storageDish = new DishStorage();
            _mapper.Map(storageLineVM, storageDish);
            await _uow.DishStorageRepository.Insert(storageDish);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid storageDishGuid)
        {
            await _uow.DishStorageRepository.Delete(storageDishGuid);
            return RedirectToAction(nameof(Index));
        }


        public async Task<double> GetDishRemains(Guid prodGuid) => (await _uow.DishStorageRepository.GetStorageRemains(prodGuid)).Sum();
    }
}
