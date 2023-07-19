using FoodLog.BLL;
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


    }
}
