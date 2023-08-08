using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
{
    private readonly FoodLogDbContext _db;
    public ProductCategoryRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<ProductCategory>> GetProdCatsByProdGuid(Guid prodGuid) => await
            _db.ProductCategories
            .Where(x => x.ProductGuid == prodGuid)
            .Include(x => x.Product)
            .Include(x => x.Category)
            .ToListAsync();

    public async Task<Guid> GetProdGuid(Guid prodCatGuid)
    {
        ProductCategory prodCat = await _db.ProductCategories.FirstOrDefaultAsync(x => x.Guid == prodCatGuid);
        return prodCat == null ? Guid.Empty : prodCat.ProductGuid;
    }
}
