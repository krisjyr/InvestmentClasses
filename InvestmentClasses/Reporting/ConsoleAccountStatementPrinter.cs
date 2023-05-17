using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Reporting
{
    public class ConsoleAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;

        public ConsoleAccountStatementPrinter(AccountStatement statement)
        {
            _statement = statement;
        }
        public void Print(Domain.Account account)
        {
            // Kasuta Console.Write, et konto väljavõte ekraanile kirjutada
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
