namespace FoodLog.DAL.Entities;

public class ProductCategory :BaseEntity
{
    public Guid ProductGuid { get; set; }
    public Guid CategoryGuid { get; set; }
    public double Percent { get; set; }
}
