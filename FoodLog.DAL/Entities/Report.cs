namespace FoodLog.DAL.Entities;
public class Report : BaseEntity
{
    public Guid ProductGuid { get; set; }
    public virtual Product Product { get; set; } = null!;

    public double CostOfBalance { get; set; }     // Стоимость остатка товара

    public double TotalIncomeWeight { get; set; }  // Всего продукта пришло за все время
    public double AveragePrice { get; set; }       // Средняя стоимость продукта
    public double TotalCost { get; set; }          // Суммарная стоимость пришедшего продукта

    public double TotalTrashWeight { get; set; }   // Всего товара списано (вес)
    public double TotalTrashCost { get; set; }     // Всего товара списано (стоимость)

    public double TotalEatenWeight { get; set; }   // Всего продукта съедено (вес)
    public double TotalEatenCost { get; set; }     // Всего продукта съедено (стоимость)

}
