using Halle.Investments.Application.Common;
using Halle.Investments.Domain.Entities.Rebalancing;
using Halle.Investments.Infraestructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>, IApplicationDbContext 
{
    public ApplicationDbContext(DbContextOptions options): base(options) { }

    //Db set
    public DbSet<RebalancingManualTransaction> RebalancingManualTransactions { get; set; } = null!;

    public DbSet<RebalancingParameters> RebalancingParameters { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definir regras
        base.OnModelCreating(modelBuilder);
    }
}