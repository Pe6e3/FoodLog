using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private readonly FoodLogDbContext _db;
    public CategoryRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }
}
