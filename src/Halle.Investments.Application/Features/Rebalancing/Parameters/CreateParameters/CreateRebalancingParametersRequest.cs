using Halle.Investments.Domain.Entities.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Application.Features.Rebalancing.Parameters.CreateParameters
{
    public record CreateRebalancingParametersRequest : IRequest<Guid>
    {
        public decimal ContributionValue { get; init; }
        public int ContributionClasses { get; init; }
        public int ContributionAssets { get; init; }
        public RebalancingMode Mode { get; init; }
    }
}
