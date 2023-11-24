using Halle.Investments.Domain.Enums;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingGoals : EntityBase
{
    public string UserId { get; set; } = null!;
    public Assets Asset { get; set; }
    public decimal Goal { get; set; }
}