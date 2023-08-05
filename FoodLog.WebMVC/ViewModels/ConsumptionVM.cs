using FoodLog.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.WebMVC.ViewModels
{
    public class ConsumptionVM : BaseAction
    {
        public double Brutto { get; set; }
        public double Netto { get; set; }
        public double TrashPercentage { get; set; }
        public double TrashWeight { get; set; }

        [ForeignKey(nameof(Purchase))]
        public Guid GuidOfPurchase { get; set; } // записываем Guid источника продукта
        public virtual Purchase? Purchase { get; set; }
    }
}
