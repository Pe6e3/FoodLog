using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.DAL.Entities;

public class Consumption : BaseAction
{
 
    public double Brutto { get; set; }
    public double Netto { get; set; }

    [ForeignKey(nameof(Purchase))]
    public Guid GuidOfPurchase { get; set; } // Guid источника продукта
    public virtual Purchase? Purchase { get; set; }
}
