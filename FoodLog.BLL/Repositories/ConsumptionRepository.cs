using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class ConsumptionRepository : GenericRepository<Consumption>, IConsumptionRepository
{
    private readonly FoodLogDbContext _db;
    public ConsumptionRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Consumption>> GetConsumptions()
    {
        IEnumerable<Consumption> consumptions = await 
            _db.Consumptions
            .Include(x=>x.Product)
            .Include(x=>x.Purchase)
            .ToListAsync();
        return consumptions;
    }
}
