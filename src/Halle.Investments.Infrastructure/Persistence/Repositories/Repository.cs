using Halle.Investments.Domain.Entities;

namespace Halle.Investments.Infrastructure.Persistence.Repositories;

internal abstract class Repository<TEntity>
    where TEntity : EntityBase
{
    protected readonly AppDbContext DbContext;

    protected Repository(AppDbContext dbContext) =>
        DbContext = dbContext;

    public void Add(TEntity entity)
    {
        DbContext
            .Set<TEntity>()
            .Add(entity);
    }
    
    public void Update(TEntity entity)
    {
        DbContext
            .Set<TEntity>()
            .Update(entity);
    }
    
    public void Remove(TEntity entity)
    {
        DbContext
            .Set<TEntity>()
            .Remove(entity);
    }
}
