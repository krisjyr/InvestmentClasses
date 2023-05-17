using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Reporting
{
    public interface IAccountStatementPrinter
    {
        void Print(Domain.Account account);
    }
}
