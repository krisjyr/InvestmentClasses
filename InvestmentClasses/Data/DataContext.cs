using System.Collections.Generic;
using InvestmentClasses.Collections;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data
{
    public class DataContext
    {
        public InstitutionsList Institutions { get; private set; } = new InstitutionsList();
        public AccountsList Accounts { get; private set; } = new AccountsList();
        public SecurablesList Securables { get; private set; } = new SecurablesList();
        public IList<ExchangeRate> ExchangeRates { get; private set; } = new List<ExchangeRate>();
        public IList<Transaction> Transactions { get; private set; } = new List<Transaction>();
        public IList<Deal> Deal { get; private set; } = new List<Deal>();
    }
}
