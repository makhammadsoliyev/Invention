using Invention.DataAccess.Contexts;
using Invention.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace Invention.DataAccess.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    private readonly InventionDbContext context;
    private readonly DbSet<TEntity> entities;

    public Repository(InventionDbContext context)
    {
        this.context = context;
        this.entities = context.Set<TEntity>();
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        var entry = entities.Remove(entity);

        return await Task.FromResult(entry.Entity);
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entry = await entities.AddAsync(entity);

        return entry.Entity;
    }

    public async Task SaveAsync()
    {
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> SelectAllAsEnumerableAsync()
    {
        return await Task.FromResult(entities.AsEnumerable());
    }

    public IQueryable<TEntity> SelectAllAsQueryable()
    {
        return entities.AsQueryable();
    }

    public async Task<TEntity> SelectByIdAsync(long id)
    {
        var entity = await entities.FirstOrDefaultAsync(e => e.Id == id);

        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entry = entities.Update(entity);

        return await Task.FromResult(entry.Entity);
    }
}