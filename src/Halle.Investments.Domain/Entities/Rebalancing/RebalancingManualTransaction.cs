using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using Halle.Investments.Domain.Interfaces;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingManualTransaction : Entity<RebalancingManualTransactionId>
{
    public override RebalancingManualTransactionId Id { get; set; } = NewId.NextGuid();
    public string Asset { get; set; } = null!;
    public decimal Quantity { get; set; }
    public decimal Goal { get; set; }
    public Assets Type { get; set; }

    public IUser User { get; set; } = null!;
    public Guid UserId { get; set; }
}