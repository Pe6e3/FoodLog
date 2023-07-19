using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class StorageProductRepository : GenericRepository<StorageProduct>, IStorageProductRepository
{
    private readonly FoodLogDbContext _db;
    public StorageProductRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
