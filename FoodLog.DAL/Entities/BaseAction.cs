namespace FoodLog.DAL.Entities;

public class BaseAction : BaseEntity
{
    public Guid ProductGuid { get; set; }
    public DateTime Date { get; set; }
    public virtual Product Product { get; set; } = null!;

}
