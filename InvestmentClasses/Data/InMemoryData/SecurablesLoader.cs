using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    internal static class SecurablesLoader
    {
        public static void LoadSecurables(DataContext context)
        {
            context.Securables.Add(new Securable { Ticker = "EUR", Name = "Euro" });
            context.Securables.Add(new Securable { Ticker = "USD", Name = "Dollar" });
            context.Securables.Add(new Securable { Ticker = "MSFT", Name = "Microsoft" });
            context.Securables.Add(new Securable { Ticker = "AAPL", Name = "Apple" });
            context.Securables.Add(new Securable { Ticker = "GOOG", Name = "Google" });
        }
    }
}