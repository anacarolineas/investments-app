using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using Halle.Investments.Domain.Interfaces;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingParameter : Entity<RebalancingParameterId>
{
    public override RebalancingParameterId Id { get; set; } = NewId.NextGuid();
    public decimal ContributionValue { get; set; }
    public int ContributionClasses { get; set; }
    public int ContributionAssets { get; set; }
    public RebalancingMode Mode { get; set; }

    public RebalancingParameter(decimal contributionValue, int contributionClasses, int contributionAssets)
    {
        ContributionValue = contributionValue;
        ContributionClasses = contributionClasses;
        ContributionAssets = contributionAssets;
        Mode = RebalancingMode.Manual;
    }
}