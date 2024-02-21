using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Infrastructure.Persistence;

namespace Halle.Investments.Infrastructure.Repositories
{
    internal abstract class Repository<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        protected readonly ApplicationDbContext DbContext;

        protected Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            await DbContext.AddAsync(entity!);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await DbContext.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            DbContext.Update(entity!);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            DbContext.UpdateRange(entities);
        }

        public void Remove(TEntity entity)
        {
            DbContext.Remove(entity!);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbContext.RemoveRange(entities);
        }
    }
}
