using Halle.Investments.Domain.Enums;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingParameters : EntityBase
{
    //FK user
    public string UserId { get; set; } = null!;
    public decimal ContributionValue { get; set; }
    public int ContributionClasses { get; set; }
    public int ContributionAssets { get; set; }
    public RebalancingMode Mode { get; set; }
}