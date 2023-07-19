using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class ConsumptionRepository : GenericRepository<Consumption>, IConsumptionRepository
{
    private readonly FoodLogDbContext _db;
    public ConsumptionRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
