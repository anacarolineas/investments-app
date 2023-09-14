namespace Halle.Investments.Domain.Entities.Wallet;

public sealed class WalletUser : EntityBase
{
    public required string Name { get; init; }
    public Guid UserId { get; set; }
    
}