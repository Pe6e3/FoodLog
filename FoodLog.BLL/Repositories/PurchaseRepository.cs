using FoodLog.DAL.Data;
using FoodLog.DAL.Entities;
using FoodLog.DAL.Interfaces;

namespace FoodLog.BLL.Repositories;

public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
{
    private readonly FoodLogDbContext _db;
    public PurchaseRepository(FoodLogDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task DeletePurchase(Guid purchaseGuid)
    {

        Purchase? purchase = await _db.Purchases.FindAsync(purchaseGuid);
        if (purchase != null)
            _db.Purchases.Remove(purchase);

        var storageProduct = await _db.ProductsStorage.FindAsync(purchaseGuid);
        if (storageProduct != null)
            _db.ProductsStorage.Remove(storageProduct);

        await _db.SaveChangesAsync();

    }
}
