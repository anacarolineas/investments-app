using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using Halle.Investments.Domain.Interfaces;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing;

public sealed class RebalancingGoals : Entity<RebalancingGoalsId>
{
    public override RebalancingGoalsId Id { get; set; } = NewId.NextGuid();
    public Assets Asset { get; set; }
    public decimal Goal { get; set; }

    public IUser User { get; set; } = null!;
    public UserId UserId { get; set; }
}