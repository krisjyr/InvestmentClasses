using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    internal static class InstituionsLoader
    {
        public static void LoadInstitutions(DataContext context)
        {
            context.Institutions.Add(new Institution { Name = "Swedbank" });
            context.Institutions.Add(new Institution { Name = "LHV" });
        }
    }
}
