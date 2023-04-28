namespace InvestmentClasses.Data.InMemoryData
{
    public class InMemoryDataLoader : IDataLoader
    {
        public void LoadData(DataContext context)
        {
            InstituionsLoader.LoadInstitutions(context);
            AccountsLoader.LoadAccounts(context);
            SecurablesLoader.LoadSecurables(context);
            ExchangeRatesLoader.LoadExchangeRates(context);

            DealsLoader.LoadDeals(context);
        }
    }
}