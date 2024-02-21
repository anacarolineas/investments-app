using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Rebalancing;
using Halle.Investments.Domain.Interfaces.Repositories;
using Halle.Investments.Infrastructure.Persistence;

namespace Halle.Investments.Infrastructure.Repositories.Rebalancing
{
    internal sealed class RebalancingUserRepository : Repository<RebalancingUser, RebalancingUserId>, IRebalancingUserRepository
    {
        public RebalancingUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}
