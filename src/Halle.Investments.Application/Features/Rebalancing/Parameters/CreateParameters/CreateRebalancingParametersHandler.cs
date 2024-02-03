using Halle.Investments.Application.Common;
using Halle.Investments.Domain.Entities.Rebalancing;
using MediatR;

namespace Halle.Investments.Application.Features.Rebalancing.Parameters.CreateParameters
{
    public sealed class CreateRebalancingParametersHandler : IRequestHandler<CreateRebalancingParametersRequest, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateRebalancingParametersHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateRebalancingParametersRequest request, CancellationToken cancellationToken)
        {
            // definir regras no validator
            // já existe parâmetros definidos para esse usuário? 1 por usuário

            var parameters = new RebalancingParameters
            {
                ContributionAssets = request.ContributionAssets,
                ContributionClasses = request.ContributionClasses,
                ContributionValue = request.ContributionValue,
                Mode = request.Mode
            };

            await _context.RebalancingParameters.AddAsync(parameters);

            await _context.SaveChangesAsync();

            return parameters.Id;
        }
    }
}
