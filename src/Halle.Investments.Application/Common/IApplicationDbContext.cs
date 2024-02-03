using Halle.Investments.Domain.Entities.Rebalancing;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Application.Common;

public interface IApplicationDbContext : IAsyncDisposable, IDisposable
{
    public DbSet<RebalancingParameters> RebalancingParameters { get; }

    public DbSet<RebalancingManualTransaction> RebalancingManualTransactions { get; }


    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}