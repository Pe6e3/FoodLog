using AutoMapper;
using FoodLog.BLL;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodLog.WebMVC.Controllers
{
    public class ProductStoragesController : Controller
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProductStoragesController(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            //IEnumerable<ProductStorage> storageProducts = await _uow.ProductStorageRepository.GetEntity(Include:"Product",Include2:"Purchase");
            IEnumerable<ProductStorage> storageProducts = await _uow.ProductStorageRepository.GetStorage();
            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storageProducts, storageLineVMs);

            return View(storageLineVMs);
        }

        public async Task<IActionResult> IndexPartial(string filter = "")
        {
            IEnumerable<ProductStorage> storageProducts = await _uow.ProductStorageRepository.GetEntity("Product", "Purchase");
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
            var storageProduct = new ProductStorage();
            _mapper.Map(storageLineVM, storageProduct);
            await _uow.ProductStorageRepository.Insert(storageProduct);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid storageProductGuid)
        {
            await _uow.ProductStorageRepository.Delete(storageProductGuid);
            return RedirectToAction(nameof(Index));
        }


        public async Task<double> GetProductRemains(Guid prodGuid) => (await _uow.ProductStorageRepository.GetStorageRemains(prodGuid)).Sum();
    }
}
