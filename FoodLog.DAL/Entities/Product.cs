﻿namespace FoodLog.DAL.Entities;

public class Product : BaseEntity
{
    public string? Name { get; set; }
    public double Calories { get; set; }
    public double Prot { get; set; }
    public double Carb { get; set; }
    public double Fat { get; set; }
    public double HarmScore { get; set; }
    public double TrashPercentage { get; set; }

    public virtual List<Category>? Categories { get; set; }

}
