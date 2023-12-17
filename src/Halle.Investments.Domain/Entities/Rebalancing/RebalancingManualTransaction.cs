using Halle.Investments.Domain.Enums;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingManualTransaction : EntityBase
{
    public Guid UserId { get; set; }
    public string Asset { get; set; } = null!;
    public decimal Quantity { get; set; }
    public decimal Goal { get; set; }
    public Assets Type { get; set; }
}