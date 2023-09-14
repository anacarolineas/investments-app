namespace Halle.Investments.Domain.Entities.Wallet;

public class WalletAsset
{
    public Guid WalletUserId { get; set; }
    public required string Ticker { get; init; }
}