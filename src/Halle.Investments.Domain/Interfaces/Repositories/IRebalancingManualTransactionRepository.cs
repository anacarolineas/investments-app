using Halle.Investments.Domain.Entities.Rebalancing;

namespace Halle.Investments.Domain.Interfaces.Repositories;

public interface IRebalancingManualTransactionRepository
{
    Task<bool> TransactionAssetExist(string asset);
}