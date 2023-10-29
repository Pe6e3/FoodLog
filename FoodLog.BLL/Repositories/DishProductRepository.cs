using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class DishProductRepository : GenericRepository<DishProduct>, IDishProductRepository
{
    private readonly FoodLogDbContext _db;
    public DishProductRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

   


}
