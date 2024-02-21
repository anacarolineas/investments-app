using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Interfaces;
using MassTransit;

namespace Halle.Investments.Domain.Entities.Rebalancing
{
    public sealed class RebalancingUser : Entity<RebalancingUserId>
    {
        public override RebalancingUserId Id { get; set; } = NewId.NextGuid();

        public IUser User { get; set; } = null!;
        public UserId UserId { get; set; }

        public RebalancingParameter RebalancingParameter { get; set; } = null!;
        public RebalancingParameterId RebalancingParameterId { get; set; }

        public ICollection<RebalancingGoal> Goals { get; set; } = null!;

        public RebalancingUser(UserId userId, RebalancingParameter parameter)
        {
            UserId = userId;
            RebalancingParameter = parameter;
        }
    }
}
