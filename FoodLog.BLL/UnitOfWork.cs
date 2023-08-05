using FoodLog.BLL.Repositories;
using FoodLog.DAL.Data;
using FoodLog.DAL.Interfaces;

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
    private ConsumptionRepository _consumptionRepository;
    private PurchaseRepository _purchaseRepository;
    private StorageProductRepository _storageProductRepository;
    private TrashRepository _trashRepository;
    private ReasonRepository _reasonRepository;
    private ProductCategoryRepository _productCategoryRepository;

    public ProductRepository ProductRepository => _productRepository ??= new ProductRepository(_db);
    public CategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_db);
    public ConsumptionRepository ConsumptionRepository => _consumptionRepository ??= new ConsumptionRepository(_db);
    public PurchaseRepository PurchaseRepository => _purchaseRepository ??= new PurchaseRepository(_db);
    public StorageProductRepository StorageProductRepository => _storageProductRepository ??= new StorageProductRepository(_db);
    public TrashRepository TrashRepository => _trashRepository ??= new TrashRepository(_db);
    public ReasonRepository ReasonRepository => _reasonRepository ??= new ReasonRepository(_db);
    public ProductCategoryRepository ProdCatRepository => _productCategoryRepository ??= new ProductCategoryRepository(_db);



}
