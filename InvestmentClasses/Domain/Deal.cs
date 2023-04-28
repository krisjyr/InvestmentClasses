using System;
using System.Collections.Generic;

namespace InvestmentClasses.Domain
{
    public class Deal
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }

        public IList<Transaction> Transactions { get; set; }
    }
}