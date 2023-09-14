using YahooFinanceApi;

var securities = await Yahoo.Symbols("AAPL", "GOOG").Fields(Field.Symbol, Field.RegularMarketPrice, Field.FiftyTwoWeekHigh).QueryAsync();
var aapl = securities["AAPL"];

Console.WriteLine(aapl);


