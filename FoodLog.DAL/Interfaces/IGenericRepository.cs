namespace FoodLog.DAL.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetEntity();
    Task<T> GetEntity(Guid Guid);
    Task<T> Insert(T entity);
    Task<T> Update(T entity);

    Task Delete(T entity);
    Task Delete(Guid entityId);


}
