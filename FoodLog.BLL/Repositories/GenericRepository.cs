using FoodLog.DAL.Data;
using FoodLog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodLog.BLL.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly FoodLogDbContext _db;
    public GenericRepository(FoodLogDbContext db)
    {
        _db = db;
    }


    public async Task<IReadOnlyList<T>> GetEntity() => await _db.Set<T>().ToListAsync();
    public async Task<IReadOnlyList<T>> GetEntity(string Include) => await _db.Set<T>().Include(Include).ToListAsync();
    public async Task<IReadOnlyList<T>> GetEntity(string Include1, string Include2) => await _db.Set<T>().Include(Include1).Include(Include2).ToListAsync();

    public async Task<T> GetEntity(Guid Guid) => await _db.Set<T>().FindAsync(Guid);

    public async Task<T> Insert(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _db.Entry(entity).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return entity;
    }
    public async Task Delete(T entity)
    {
        _db.Set<T>().Remove(entity);
        await _db.SaveChangesAsync();
    }

    public async Task Delete(Guid entityGuid)
    {
        T? entity = await _db.Set<T>().FindAsync(entityGuid);
        if (entity != null) await Delete(entity);
    }
}
