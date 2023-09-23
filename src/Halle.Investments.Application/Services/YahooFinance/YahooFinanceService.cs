using YahooFinanceApi;

namespace Halle.Investments.Application.Services.YahooFinance;

public sealed class YahooFinanceService : IYahooFinanceService
{
    public async Task GetAssetsBySymbols(string[] symbols)
    {
        await Yahoo.Symbols(symbols)
            .QueryAsync();
    }
}