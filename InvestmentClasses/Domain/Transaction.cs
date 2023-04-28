using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Domain
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public DateTime Time { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Account OwningAccount { get; set; }
        public Account OtherAccount { get; set; }
        public Securable Securable { get; set; }
    }
}
