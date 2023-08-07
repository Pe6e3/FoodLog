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

    public async Task<Guid> GetProdGuid(Guid prodCatGuid)
    {
        ProductCategory prodCat = await _db.ProductCategories.FirstOrDefaultAsync(x=>x.Guid == prodCatGuid);
        return prodCat == null ? Guid.Empty : prodCat.ProductGuid;
    }
}
