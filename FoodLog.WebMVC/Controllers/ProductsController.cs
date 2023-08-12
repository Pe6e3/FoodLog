using FoodLog.BLL;
using Microsoft.AspNetCore.Mvc;
using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using FoodLog.WebMVC.ViewModels;
using AutoMapper;

namespace FoodLog.DAL.Controllers
{
    public class ProductsController : Controller
    {
        private readonly UnitOfWork _uow;
        private readonly IMapper _mapper;

        public ProductsController(UnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            //IEnumerable<Product> products = await _uow.ProductRepository.GetEntity();
            IEnumerable<Product> products = await _uow.ProductRepository.GetProductsWithCatPercent();
            IEnumerable<ProductCatPercentVM> productsVM = new List<ProductCatPercentVM>();
            _mapper.Map(products, productsVM);

            foreach (ProductCatPercentVM productVM in productsVM)
                productVM.PercentSum = await _uow.ProdCatRepository.GetCatsSum(productVM.ProductGuid);

            return View(productsVM.OrderByDescending(x => x.Calories));
        }


        public async Task<IActionResult> Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _uow.ProductRepository.Insert(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid prodGuid)
        {
            await _uow.ProductRepository.Delete(prodGuid);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(Guid prodGuid) => View(await _uow.ProductRepository.GetEntity(prodGuid));

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            await _uow.ProductRepository.Update(product);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Production(Product product)
        {

            IEnumerable<ProductStorage> productsStorage = await _uow.ProductStorageRepository.GetEntity("Product", "Purchase");
            var storageLineVM = new List<StorageLineVM>();
            _mapper.Map(productsStorage, storageLineVM);
            return View(storageLineVM);
        }



        public async Task<IActionResult> AddProductToDish(Consumption consumption,  Guid dishGuid )
        {
            ConsumptionVM consumptionVM = new ConsumptionVM();
            _mapper.Map(consumption, consumptionVM);

            RedirectToAction("CalculateConsume", "Consumptions", consumptionVM);
            // TODO:
            // 1. Списываем продукт в том количестве, которое указали:
                // а. Убавляем со склада
                // б. Создаем списание
                // в. НЕ создаем потребление
            // 2. Заполняем промежуточную таблицу DishProduct
            // 3. Добавляем продукту с Guid = dishGuid данные: БЖУ, цена, стоимость, количество

            return View(nameof(Index));
        }

    }
}
