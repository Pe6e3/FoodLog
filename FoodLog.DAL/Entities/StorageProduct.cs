namespace FoodLog.DAL.Entities;

public class StorageProduct : BaseEntity
{

    public Guid ProductGuid { get; set; }
    public Guid SourceGuid { get; set; } // записываем Guid источника, чтобы удалить запись со склада если удалим запись из журнала покупок/производства и тп

    public virtual Product Product { get; set; } = null!;

    public double CurrentWeight { get; set; }
    public double CurrentCost { get; set; }


    public double WeightConsume{ get; set; }      // Сколько будем потреблять
    public double WeightRemainsAfter{ get; set; } // Сколько после этого останется



}
