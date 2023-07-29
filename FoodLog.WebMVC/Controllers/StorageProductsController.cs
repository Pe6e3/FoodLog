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


        [HttpPost]   
        public async Task<IActionResult> CalculateConsume([FromBody] Consumption consumption)
        {
            IEnumerable<StorageProduct> storage = await _uow.StorageProductRepository.FilterProducts(consumption.ProductGuid);
            double consumeWeigth = consumption.Brutto;
 
            foreach (StorageProduct storageProduct in storage)
            {
                if (consumeWeigth > storageProduct.CurrentWeight)
                    storageProduct.WeightConsume = storageProduct.CurrentWeight;
                else storageProduct.WeightConsume = consumeWeigth;
                consumeWeigth -= storageProduct.WeightConsume;
                storageProduct.WeightRemainsAfter = storageProduct.CurrentWeight - storageProduct.WeightConsume;
            }
            await _uow.StorageProductRepository.Update(storage);

            IEnumerable<StorageLineVM> storageLineVMs = new List<StorageLineVM>();
            _mapper.Map(storage, storageLineVMs);
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
