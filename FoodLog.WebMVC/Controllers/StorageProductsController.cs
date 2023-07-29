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
            double[] storageRemains = await _uow.StorageProductRepository.GetStorageRemains(consumption.ProductGuid);   // получаем массив со складскими остатками по данному продукту
            double[] consumeArray = new double[storageRemains.Length];                                                  // создаем пустой массив с таким же размером - в него будем вписывать сколько списывать по факту
            double consumeWeigth = consumption.Brutto;
            for (int i = 0; i < storageRemains.Length; i++)
            {
                if (consumeWeigth > storageRemains[i])
                    consumeArray[i] = storageRemains[i];
                else consumeArray[i] = consumeWeigth;
                consumeWeigth -= consumeArray[i];
                //Console.WriteLine($"{i}й продукт: {consumeArray[i]}/{storageRemains[i]}");
            }
            //Console.WriteLine($"Остаток: {consumeWeigth}");
            if (consumeWeigth!=0)
                return Json(new { message = "На складе недостаточно продукта"});

            //ViewBag.ConsumeArray = consumeArray;
            return Json(new { message = consumeArray});
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
