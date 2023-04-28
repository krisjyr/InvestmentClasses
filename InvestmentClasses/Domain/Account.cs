using System.Collections.Generic;

namespace InvestmentClasses.Domain
{
    public class Account
    {
        public string AccountNo { get; set; }
        public string Name { get; set; }

        public Institution Institution { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
