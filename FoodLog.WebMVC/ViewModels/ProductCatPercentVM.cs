using FoodLog.DAL.Entities;

namespace FoodLog.WebMVC.ViewModels
{
    public class ProductCatPercentVM : Product
    {
        public Guid ProductGuid { get; set; }
        public double PercentSum { get; set; }
        public List<ProductCategory>? CategoryList { get; set; }
    }
}
