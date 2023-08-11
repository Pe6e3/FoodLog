using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class ProductStorageRepository : GenericRepository<ProductStorage>, IProductStorageRepository
{
    private readonly FoodLogDbContext _db;
    public ProductStorageRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<List<ProductStorage>> FilterProducts(Guid productGuid)=>
        await _db.ProductStorages.Where(x=>x.ProductGuid == productGuid).ToListAsync();

    public async Task<IEnumerable<ProductStorage>> GetStorage()
    {
        IEnumerable<ProductStorage> storageProducts = await
            _db.ProductStorages
            .Include(x => x.Product)
            .Include(y => y.Purchase)
            .ToListAsync();
        return storageProducts;
    }

    public async Task<double[]> GetStorageRemains(Guid productGuid)
    {
        List<ProductStorage> storageProducts = await _db.ProductStorages.Where(x => x.ProductGuid == productGuid).ToListAsync();
        double[] storageRemains = new double[storageProducts.Count];
        int count = 0;
        foreach (ProductStorage storageProduct in storageProducts)
            storageRemains[count++] = storageProduct.CurrentWeight;
        return storageRemains;
    }
}
