using System;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    public static class ExchangeRatesLoader
    {
        public static void LoadExchangeRates(DataContext context)
        {
            var msft = context.Securables.GetByTicker("MSFT");
            var usd = context.Securables.GetByTicker("USD");

            context.ExchangeRates.Add(new ExchangeRate { From = msft, To = usd, Time = DateTime.Parse("2023-04-01"), Rate = 266.04m });
            context.ExchangeRates.Add(new ExchangeRate { From = msft, To = usd, Time = DateTime.Parse("2023-04-02"), Rate = 268.12m });
            context.ExchangeRates.Add(new ExchangeRate { From = msft, To = usd, Time = DateTime.Parse("2023-04-03"), Rate = 262.33m });
            context.ExchangeRates.Add(new ExchangeRate { From = msft, To = usd, Time = DateTime.Parse("2023-04-04"), Rate = 263.17m });
            context.ExchangeRates.Add(new ExchangeRate { From = msft, To = usd, Time = DateTime.Parse("2023-04-05"), Rate = 267.46m });
        }
    }
}
