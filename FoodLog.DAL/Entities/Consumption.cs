namespace FoodLog.DAL.Entities;

public class Consumption : BaseAction
{
 
    public double Brutto { get; set; }
    public double Netto { get; set; }
    public double TrashWeight { get; set; }
    public double TrashPercentage { get; set; }

    public double Caloriers { get; set; }
    public double Prot { get; set; }
    public double Carb { get; set; }
    public double Fat { get; set; }
    public double HarmScore { get; set; }
}
