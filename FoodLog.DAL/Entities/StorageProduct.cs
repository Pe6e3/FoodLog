namespace FoodLog.DAL.Entities;

public class StorageProduct : BaseEntity
{

    public Guid ProductGuid { get; set; }
    public virtual Product Product { get; set; } = null!;

    public double CurrentWeight { get; set; }
    public double CurrentCost { get; set; }

}
