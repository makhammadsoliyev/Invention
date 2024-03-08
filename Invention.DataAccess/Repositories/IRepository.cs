using Invention.Domain.Commons;

namespace Invention.DataAccess.Repositories;

public interface IRepository<TEntity> where TEntity : Auditable
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<TEntity> SelectByIdAsync(long id);
    Task<IEnumerable<TEntity>> SelectAllAsEnumerableAsync();
    IQueryable<TEntity> SelectAllAsQueryable();
    Task SaveAsync();
}
