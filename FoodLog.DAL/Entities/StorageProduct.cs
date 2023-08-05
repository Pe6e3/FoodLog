using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.DAL.Entities;

public class StorageProduct : BaseEntity
{

    public Guid ProductGuid { get; set; }
    public virtual Product Product { get; set; } = null!;

    [ForeignKey(nameof(Purchase))]
    public Guid GuidOfPurchase { get; set; } // записываем Guid источника продукта
    public virtual Purchase? Purchase { get; set; }


    public double CurrentWeight { get; set; }
    public double CurrentCost { get; set; }


    public double WeightConsume{ get; set; }      // Сколько будем потреблять
    public double WeightRemainsAfter{ get; set; } // Сколько после этого останется



}
