using System.ComponentModel.DataAnnotations.Schema;

namespace FoodLog.DAL.Entities;

public class StorageProduct : StorageDish
{

   Guid DishGuid { get; set; }



}
