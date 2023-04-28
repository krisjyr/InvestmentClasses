using System;
using System.Collections.Generic;
using System.Linq;
using InvestmentClasses.Data;
using InvestmentClasses.Data.InMemoryData;
using InvestmentClasses.Domain;

namespace InvestmentClasses
{
    class Program
    {
        private static DataContext _dataContext = new DataContext();

        static void Main(string[] args)
        {
            IDataLoader loader = new InMemoryDataLoader();
            loader.LoadData(_dataContext);

            var context = _dataContext;
            TransactionsLoader.LoadTransactions(context);

            // Print account history
            var accounts = context.Accounts.ToList();
            foreach (var account in accounts)
            {
                Console.WriteLine(account.Name);
                Console.WriteLine("TransactionID|Date|Amount|Currency|Description|Balance");
                Console.WriteLine("----------------------------------------------------------");

                var balance = 0m;
                var transactions = account.Transactions.OrderBy(t => t.Time);
                foreach (var transaction in transactions)
                {
                    var sign = transaction.Amount < 0 ? "-" : "+";
                    var amount = sign + Math.Abs(transaction.Amount).ToString("F");
                    var transactionBalance = balance + transaction.Amount;

                    Console.WriteLine($"{transaction.TransactionId}|{transaction.Time:yyyy-MM-dd HH:mm:ss}|{amount}|{transaction.Securable.Ticker}|{transaction.Description}|{transactionBalance:F}");

                    balance = transactionBalance;
                }

                Console.WriteLine();
            }
        }
    }
}
