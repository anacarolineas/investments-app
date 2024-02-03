using Halle.Investments.Application.Gateway;
using YahooFinanceApi;

namespace Halle.Investments.Infrastructure.ExternalServices.YahooFinance;

public class YahooFinanceApi : IYahooFinanceApi
{
    public async Task GetAssetsBySymbols(string[] symbols)
    {
        await Yahoo.Symbols(symbols)
            .QueryAsync();
    }
}