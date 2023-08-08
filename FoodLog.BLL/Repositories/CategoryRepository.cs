using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    private readonly FoodLogDbContext _db;
    public CategoryRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Category>> GetUnusedCats(Guid prodGuid)
    {
        List<Category> allCategories = await _db.Categories.ToListAsync();
        List<Guid> usedCategoryGuids = await _db.ProductCategories
            .Where(x => x.ProductGuid == prodGuid)
            .Select(x => x.CategoryGuid)
            .ToListAsync();

        List<Category> unusedCategories = allCategories
            .Where(category => !usedCategoryGuids.Contains(category.Guid))
            .ToList();

        return unusedCategories;
    }


}
