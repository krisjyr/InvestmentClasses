using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Reporting
{
    public class AccountStatementBuilder
    {
        private readonly Account _account;

        public AccountStatementBuilder(Account account)
        {
            _account = account;
        }

        public AccountStatement Build(DateTime fromDate, DateTime toDate)
        {
            var statement = new AccountStatement();

            BuildHeader(statement.Header, fromDate, toDate);
            BuildEntries(statement, fromDate, toDate);

            return statement;
        }

        private void BuildHeader(AccountStatementHeader header, DateTime fromDate, DateTime toDate)
        {

        }

        // Kannete osa (transactionite põhjal AccountStatementEntry´)
        private void BuildEntries(AccountStatement statement, DateTime fromDate, DateTime toDate)
        { 
         
        }
    }
}
