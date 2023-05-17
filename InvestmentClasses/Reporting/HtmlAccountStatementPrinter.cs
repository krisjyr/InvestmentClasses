using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Reporting
{
    public class HtmlAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;
        private readonly string _fileName;

        public HtmlAccountStatementPrinter(AccountStatement statement, string fileName)
        {
            _statement = statement;
            _fileName = fileName;
        }

        public void Print(Domain.Account account)
        {
            if(File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }

            // Kasuta File.AppendAllText(), et kirjutada HTML välja
            File.AppendAllText(_fileName, "<html>");

            File.AppendAllText(_fileName, $@"
            <head>
                <title>Konto Väljavõte - {account.Name}</title>
                <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>
                <script src='https://code.jquery.com/jquery-3.3.1.slim.min.js' integrity='sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo' crossorigin='anonymous'></script>
                <script src='https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js' integrity='sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1' crossorigin='anonymous'></script>
                <script src='https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>
            </head>
            <body>
                <div>
                    <div>
                        <h1>Konto Väljavõte - {account.Name}</h1>
                    </div>
                <table class='table table-striped'>
                  <thead>
                    <tr>
                      <th scope='col'>ID</th>
                      <th scope='col'>Amount</th>
                      <th scope='col'>Currency</th>
                      <th scope='col'>Description</th>
                      <th scope='col'>Balance</th>
                      <th scope='col'>Date</th>
                    </tr>
                  </thead>
                    <tbody>
                ");
            var bal = 0m;
            foreach (var transaction in account.Transactions)
            {
                var balance = bal + transaction.Amount;
                File.AppendAllText(_fileName, $@"
                <tr>
                  <th scope='row'>{transaction.TransactionId}</th>
                  <td>{transaction.Amount}€</td>
                  <td>{transaction.Securable.Ticker}</td>
                  <td>{transaction.Description}</td>
                  <td>{balance}€</td>
                  <td>{transaction.Time:yyyy-MM-dd HH:mm:ss}</td>
                </tr>
                ");
                bal = balance;
            }
            File.AppendAllText(_fileName, $@"</div>
            </body>");


            File.AppendAllText(_fileName, "</html>");
        }
    }
}
