namespace Halle.Investments.Application.Gateway;

public interface IYahooFinanceApi
{
    Task GetAssetsBySymbols(string[] symbols);
}