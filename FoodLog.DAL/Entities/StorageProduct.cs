namespace FoodLog.DAL.Entities;

public class StorageProduct : BaseEntity
{
    public double CurrentWeight { get; set; }
    public double Cost { get; set; }

    public double TotalIncomeWeight { get; set; }
    public double AveragePrice { get; set; }
    public double TotalCost { get; set; }

    public double TotalTrashWeight { get; set; }
    public double TotalTrashCost { get; set; }

    public double TotalEatenWeight { get; set; }
    public double TotalEatenCost { get; set; }

    public virtual Product Product { get; set; } = null!;



}
