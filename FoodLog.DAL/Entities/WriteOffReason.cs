namespace FoodLog.DAL.Entities;


// Причины списания
public class WriteOffReason : BaseEntity
{
    public string ReasonName { get; set; } = null!;
}