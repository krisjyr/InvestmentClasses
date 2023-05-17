using System.Collections.Generic;

namespace InvestmentClasses.Reporting
{
    public class AccountStatement
    {
        public AccountStatementHeader Header { get; set; }
        public IList<AccountStatementEntry> Entries { get; set; }

        public AccountStatement()
        {
            Header = new AccountStatementHeader();
            Entries = new List<AccountStatementEntry>();
        }
    }
}