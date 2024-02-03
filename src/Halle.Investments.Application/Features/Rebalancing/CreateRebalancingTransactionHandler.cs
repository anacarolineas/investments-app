using MediatR;

namespace Halle.Investments.Application.Features.Rebalancing;

public class CreateRebalancingTransactionHandler : IRequestHandler<CreateRebalancingTransactionRequest>
{
    public Task Handle(CreateRebalancingTransactionRequest request, CancellationToken cancellationToken)
    {
        //já existe esse ativo lançado?
        // criar transação

        return Task.CompletedTask;
    }
}