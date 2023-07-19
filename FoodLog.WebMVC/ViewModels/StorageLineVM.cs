using FoodLog.DAL.Entities;

namespace FoodLog.WebMVC.ViewModels;

public class StorageLineVM
{
    public Guid Guid { get; set; }
    public Guid ProductGuid { get; set; }


    public string ProductName { get; set; } = null!;

    public double CurrentWeight { get; set; }
    public double CurrentCost { get; set; }

}
