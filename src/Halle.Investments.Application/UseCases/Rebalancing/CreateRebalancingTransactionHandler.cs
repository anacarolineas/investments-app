using MediatR;

namespace Halle.Investments.Application.UseCases.Rebalancing;

public class CreateRebalancingTransactionHandler : IRequestHandler<CreateRebalancingTransactionCommand>
{
    public Task Handle(CreateRebalancingTransactionCommand request, CancellationToken cancellationToken)
    {
        //já existe esse ativo lançado?
        // criar transação

        return Task.CompletedTask;
    }
}