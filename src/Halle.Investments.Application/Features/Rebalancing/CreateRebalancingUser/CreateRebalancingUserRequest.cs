using Ardalis.Result;
using Halle.Investments.Domain.Entities.Common;
using Halle.Investments.Domain.Entities.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Application.Features.Rebalancing.CreateRebalancingUser
{
    public record CreateRebalancingUserRequest : IRequest<Result<RebalancingUserId>>
    {
        public decimal ContributionValue { get; init; }
        public int ContributionClasses { get; init; }
        public int ContributionAssets { get; init; }
        public RebalancingMode Mode { get; init; } = RebalancingMode.Manual;
    }
}
