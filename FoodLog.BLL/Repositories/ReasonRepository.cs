using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class ReasonRepository : GenericRepository<WriteOffReason>, IReasonRepository
{
    private readonly FoodLogDbContext _db;
    public ReasonRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
