using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class TrashRepository : GenericRepository<Trash>, ITrashRepository
{
    private readonly FoodLogDbContext _db;
    public TrashRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Trash>> GetTrashes(int count)
    {
        IQueryable<Trash> query = _db.Trashes
         .Include(x => x.Product)
         .Include(x => x.WriteOffReason)
         .OrderByDescending(x => x.Date);

        if (count > 0) query = query.Take(count);

        IEnumerable<Trash> consumptions = await query.ToListAsync();

        return consumptions;
    }
}
