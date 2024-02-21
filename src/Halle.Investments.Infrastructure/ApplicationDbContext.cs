using Halle.Investments.Application.Common;
using Halle.Investments.Domain.Entities.Rebalancing;
using Halle.Investments.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Halle.Investments.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>, IApplicationDbContext 
{
    public ApplicationDbContext(DbContextOptions options): base(options) { }


    public DbSet<RebalancingParameter> RebalancingParameters { get; set; } = null!;

    public DbSet<RebalancingUser> RebalancingUsers { get; set; } = null!;

    public DbSet<RebalancingGoal> RebalancingGoals { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definir regras
        base.OnModelCreating(modelBuilder);
    }
}