using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodLog.WebMVC.Controllers
{
    public class StorageProductsController : Controller
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public StorageProductsController(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<StorageProduct> storageProducts = await _uow.StorageProductRepository.GetEntity("Product");
            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storageProducts, storageLineVMs);

            return View(storageLineVMs);
        }

        public async Task<IActionResult> IndexPartial(string filter = "")
        {
            IEnumerable<StorageProduct> storageProducts = await _uow.StorageProductRepository.GetEntity("Product");
            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storageProducts, storageLineVMs);
            ViewBag.Filter = filter;

            return PartialView("_StorageTable", storageLineVMs);
        }



        public async Task<IActionResult> Create()
        {
            ViewBag.AllProducts = await _uow.ProductRepository.GetEntity();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StorageLineVM storageLineVM)
        {
            var storageProduct = new StorageProduct();
            _mapper.Map(storageLineVM, storageProduct);
            await _uow.StorageProductRepository.Insert(storageProduct);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid storageProductGuid)
        {
            await _uow.StorageProductRepository.Delete(storageProductGuid);
            return RedirectToAction(nameof(Index));
        }
    }
}
