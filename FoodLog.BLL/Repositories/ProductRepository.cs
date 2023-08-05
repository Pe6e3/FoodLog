using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly FoodLogDbContext _db;
    public ProductRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Guid> GetProdGuidByPurchaseGuid(Guid purchaseGuid)
    {
        Purchase? purchase = await _db.Purchases.FirstOrDefaultAsync(x => x.Guid == purchaseGuid);
        return purchase == null ? Guid.Empty : purchase.ProductGuid;
    }

    public async Task<List<Product>> ProdListFromStorage()
    {
        List<StorageProduct> storageProducts = await _db.StorageProducts.ToListAsync();
        List<Product> allProducts = await _db.Products.ToListAsync();
        List<Product> products = allProducts
            .Where(p => storageProducts.Any(sp => sp.ProductGuid == p.Guid))
            .ToList();

        return products;
    }


}
