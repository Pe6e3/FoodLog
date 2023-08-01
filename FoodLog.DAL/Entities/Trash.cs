using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.DAL.Entities;

// Списания продуктов
public class Trash : BaseAction
{
    public Guid WriteOffReasonGuid { get; set; } // Guid причины списания
    public virtual WriteOffReason? WriteOffReason { get; set; }

    [ForeignKey(nameof(Purchase))]
    public Guid GuidOfPurchase { get; set; } // записываем Guid источника продукта
    public virtual Purchase? Purchase { get; set; }

    public double TrashWeight { get; set; } // Вес списания
    public double TrashCost { get; set; }   // Стоимость списанных продуктов
}

 