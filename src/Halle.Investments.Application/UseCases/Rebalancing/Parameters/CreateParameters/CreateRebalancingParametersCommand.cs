using Halle.Investments.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halle.Investments.Application.UseCases.Rebalancing.Parameters.CreateParameters
{
    public record CreateRebalancingParametersCommand : IRequest<Guid>
    {
        public decimal ContributionValue { get; init; }
        public int ContributionClasses { get; init; }
        public int ContributionAssets { get; init; }
        public RebalancingMode Mode { get; init; }
    }
}
