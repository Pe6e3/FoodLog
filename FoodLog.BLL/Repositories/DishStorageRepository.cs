using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class DishStorageRepository : GenericRepository<DishStorage>, IDishStorageRepository
{
    private readonly FoodLogDbContext _db;
    public DishStorageRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<List<DishStorage>> FilterDishes(Guid productGuid)=>
        await _db.DishesStorage.Where(x=>x.ProductGuid == productGuid).ToListAsync();

    public async Task<IEnumerable<DishStorage>> GetStorage()
    {
        IEnumerable<DishStorage> storageDishes = await
            _db.DishesStorage
            .Include(x => x.Product)
            .Include(y => y.Purchase)
            .ToListAsync();
        return storageDishes;
    }

    public async Task<double[]> GetStorageRemains(Guid productGuid)
    {
        List<DishStorage> storageDishes = await _db.DishesStorage.Where(x => x.ProductGuid == productGuid).ToListAsync();
        double[] storageRemains = new double[storageDishes.Count];
        int count = 0;
        foreach (DishStorage storageDish in storageDishes)
            storageRemains[count++] = storageDish.CurrentWeight;
        return storageRemains;
    }
}
