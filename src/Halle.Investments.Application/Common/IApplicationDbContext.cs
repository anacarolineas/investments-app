using Halle.Investments.Domain.Entities.Rebalancing;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Application.Common;

public interface IApplicationDbContext : IAsyncDisposable, IDisposable
{
    public DbSet<RebalancingUser> RebalancingUsers { get; }
    public DbSet<RebalancingGoal> RebalancingGoals { get; }
    public DbSet<RebalancingParameter> RebalancingParameters { get; }


    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}