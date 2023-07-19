using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class TrashRepository : GenericRepository<Trash>, ITrashRepository
{
    private readonly FoodLogDbContext _db;
    public TrashRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
