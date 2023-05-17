using System;

namespace InvestmentClasses.Reporting
{
    public class AccountStatementHeader
    {
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal StartingBalance { get; set; }
    }
}
