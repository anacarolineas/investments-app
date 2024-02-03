using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using Halle.Investments.Domain.Interfaces;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public class RebalancingParameters : Entity<RebalancingParametersId>
{
    public override RebalancingParametersId Id { get; set; } = NewId.NextGuid();
    public decimal ContributionValue { get; set; }
    public int ContributionClasses { get; set; }
    public int ContributionAssets { get; set; }
    public RebalancingMode Mode { get; set; }

    public IUser User { get; set; } = null!;
    public UserId UserId { get; set; }
}