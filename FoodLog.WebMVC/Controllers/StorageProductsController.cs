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
    }
}
