using System;
using System.Linq;
using InvestmentClasses.Data;
using InvestmentClasses.Data.InMemoryData;
using InvestmentClasses.Reporting;

namespace InvestmentClasses
{
    class Program
    {
        private static DataContext _dataContext = new DataContext();

        static void Main(string[] args)
        {
            IDataLoader loader = new InMemoryDataLoader();
            loader.LoadData(_dataContext);

            var account = _dataContext.Accounts.GetByName("LHV");
            var builder = new AccountStatementBuilder(account);
            var statement = builder.Build(DateTime.Now.Date.AddDays(-30), DateTime.Now.Date);
            TransactionsLoader.LoadTransactions(_dataContext);
            var accounts = _dataContext.Accounts.ToList();

            IAccountStatementPrinter printer;
            foreach(var accountt in accounts)
            {
                printer = new HtmlAccountStatementPrinter(statement, "statement.html");
                printer.Print(accountt);

                printer = new ConsoleAccountStatementPrinter(statement);
                printer.Print(accountt);

            }
            
        }
    }
}
