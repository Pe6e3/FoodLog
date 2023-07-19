using FoodLog.BLL.Repositories;
using FoodLog.DAL.Data;

namespace FoodLog.BLL;

public class UnitOfWork
{
    private readonly FoodLogDbContext _db;
    public UnitOfWork(FoodLogDbContext db)
    {
        _db = db;
    }

    private ProductRepository _productRepository;
    private CategoryRepository _categoryRepository;

    public ProductRepository ProductRepository => _productRepository ??= new ProductRepository(_db);
    public CategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_db);



}
