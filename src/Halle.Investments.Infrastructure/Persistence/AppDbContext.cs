using Halle.Investments.Application.Data;
using Halle.Investments.Domain.Entities.Rebalancing;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions options): base(options) { }

    //Db set
    public DbSet<RebalancingManualTransaction> RebalancingManualTransactions { get; set; } = null!;

    public DbSet<RebalancingParameters> RebalancingParameters { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definir regras
        base.OnModelCreating(modelBuilder);
    }
}