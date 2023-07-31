using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class ReasonRepository : GenericRepository<WriteOffReason>, IReasonRepository
{
    private readonly FoodLogDbContext _db;
    public ReasonRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Guid> ConsumeReason()
    {
        WriteOffReason reason = await _db.WriteOffReasons.FirstOrDefaultAsync(x => x.ReasonName == "Несъедобная часть");
        return reason.Guid;
    }
}
