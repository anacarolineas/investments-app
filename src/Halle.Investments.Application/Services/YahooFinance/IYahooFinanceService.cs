namespace Halle.Investments.Application.Services.YahooFinance;

public interface IYahooFinanceService
{ 
    Task GetAssetsBySymbols(string[] symbols);
}