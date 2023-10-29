using System.ComponentModel.DataAnnotations;

namespace FoodLog.DAL.Entities
{
    public class DishProduct 
    {
        [Key]
        public Guid Guid { get; set; }
        public Guid ProductGuid { get; set; }
        public Guid DishGuid { get; set; }
        public double Netto { get; set; }
    }
}
