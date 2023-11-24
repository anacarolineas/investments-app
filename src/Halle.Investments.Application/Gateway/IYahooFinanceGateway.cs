namespace Halle.Investments.Application.Gateway;

public interface IYahooFinanceGateway
{
    Task GetAssetsBySymbols(string[] symbols);
}