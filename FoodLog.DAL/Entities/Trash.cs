namespace FoodLog.DAL.Entities;

public class Trash : BaseAction
{
    public int MyProperty { get; set; }
    public Guid WriteOffReasonGuid { get; set; }
    public virtual WriteOffReason WriteOffReason { get; set; } = null!;

    public double TrashWeight { get; set; }
    public double TrashCost { get; set; }
}


public class WriteOffReason : BaseEntity
{
    public string ReasonName { get; set; } = null!;
}