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
 

    public async Task<IEnumerable<Consumption>> GetConsumptions(int count = 0)
    {
        IQueryable<Consumption> query = _db.Consumptions
            .Include(x => x.Product)
            .Include(x => x.Purchase)
            .OrderByDescending(x => x.Date);

        if (count > 0) query = query.Take(count);

        IEnumerable<Consumption> consumptions = await query.ToListAsync();

        return consumptions;
    }

}
