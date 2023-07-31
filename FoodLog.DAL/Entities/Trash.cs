namespace FoodLog.DAL.Entities;

// Списания продуктов
public class Trash : BaseAction
{
    public Guid WriteOffReasonGuid { get; set; } // Guid причины списания
    public virtual WriteOffReason? WriteOffReason { get; set; }

    public double TrashWeight { get; set; } // Вес списания
    public double TrashCost { get; set; }   // Стоимость списанных продуктов
}

 