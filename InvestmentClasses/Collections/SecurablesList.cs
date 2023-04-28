using System.Collections.Generic;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Collections
{
    public class SecurablesList : List<Securable>
    {
        public Securable GetByTicker(string ticker)
        {
            return this.Where(i => i.Ticker.ToLower() == ticker.ToLower())
                       .FirstOrDefault();
        }
    }
}