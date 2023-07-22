namespace FoodLog.DAL.Entities;

public class Consumption : BaseAction
{
 
    public double Brutto { get; set; }
    public double Netto { get; set; }
    public double TrashWeight { get; set; }
    public double TrashPercentage { get; set; }

}
