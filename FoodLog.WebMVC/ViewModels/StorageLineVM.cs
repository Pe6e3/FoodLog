using FoodLog.DAL.Entities;

namespace FoodLog.WebMVC.ViewModels;

public class StorageLineVM
{
    public Guid Guid { get; set; }
    public Guid ProductGuid { get; set; }
    public Guid SourceGuid { get; set; } // записываем Guid источника продукта
    public virtual Purchase? Purchase { get; set; }

    public string ProductName { get; set; } = null!;

    public double CurrentWeight { get; set; }
    public double CurrentCost { get; set; }
    public double WeightConsume { get; set; }      // Сколько будем потреблять
    public double WeightRemainsAfter { get; set; } // Сколько после этого останется


}
