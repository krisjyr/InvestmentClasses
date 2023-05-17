using System;

namespace InvestmentClasses.Reporting
{
    public class AccountStatementEntry
    {
        public string TransactionId { get; set; }
        public DateTime Time { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Securable { get; set; }
        public string Description { get; set; }
        public string OtherAccount { get; set; }
    }
}
