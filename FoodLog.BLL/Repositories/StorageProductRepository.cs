using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class StorageProductRepository : GenericRepository<StorageProduct>, IStorageProductRepository
{
    private readonly FoodLogDbContext _db;
    public StorageProductRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<List<StorageProduct>> FilterProducts(Guid productGuid)=>
        await _db.StorageProducts.Where(x=>x.ProductGuid == productGuid).ToListAsync();

    public async Task<double[]> GetStorageRemains(Guid productGuid)
    {
        List<StorageProduct> storageProducts = await _db.StorageProducts.Where(x => x.ProductGuid == productGuid).ToListAsync();
        double[] storageRemains = new double[storageProducts.Count];
        int count = 0;
        foreach (StorageProduct storageProduct in storageProducts)
            storageRemains[count++] = storageProduct.CurrentWeight;
        return storageRemains;
    }
}
