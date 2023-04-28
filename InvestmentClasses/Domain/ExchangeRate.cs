using System;

namespace InvestmentClasses.Domain
{
    public class ExchangeRate
    {
        public DateTime Time { get; set; }
        public decimal Rate { get; set; }

        public Securable From { get; set; }
        public Securable To { get; set; }
    }
}
