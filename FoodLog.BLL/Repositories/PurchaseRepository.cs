using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
{
    private readonly FoodLogDbContext _db;
    public PurchaseRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
