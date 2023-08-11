using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.DAL.Entities;

public class ProductStorage : DishStorage
{

   Guid DishGuid { get; set; }



}
