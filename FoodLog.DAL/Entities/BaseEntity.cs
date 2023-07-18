using System.ComponentModel.DataAnnotations;

namespace FoodLog.DAL.Entities;

public class BaseEntity
{
    [Key]
    public Guid Guid { get; set; }
}
