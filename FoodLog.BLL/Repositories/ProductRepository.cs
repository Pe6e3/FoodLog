using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly FoodLogDbContext _db;
    public ProductRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
