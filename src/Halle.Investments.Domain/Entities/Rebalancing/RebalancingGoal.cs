using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingGoal : Entity<RebalancingGoalId>
{
    public override RebalancingGoalId Id { get; set; } = NewId.NextGuid();
    public Assets Asset { get; set; }
    public decimal Goal { get; set; }

    public RebalancingUser RebalancingUser { get; set; } = null!;
    public RebalancingUserId RebalancingUserId { get; set; }
}