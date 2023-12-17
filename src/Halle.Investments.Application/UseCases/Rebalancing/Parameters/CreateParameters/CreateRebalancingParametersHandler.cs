using Halle.Investments.Application.Data;
using Halle.Investments.Domain.Entities.Rebalancing;
using MediatR;

namespace Halle.Investments.Application.UseCases.Rebalancing.Parameters.CreateParameters
{
    public sealed class CreateRebalancingParametersHandler : IRequestHandler<CreateRebalancingParametersCommand, Guid>
    {
        private readonly IAppDbContext _context;

        public CreateRebalancingParametersHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateRebalancingParametersCommand request, CancellationToken cancellationToken)
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
