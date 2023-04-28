using System.Collections.Generic;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Collections
{
    public class InstitutionsList : List<Institution>
    {
        public Institution GetByName(string name)
        {
            return this.Where(i => i.Name.ToLower() == name.ToLower())
                       .FirstOrDefault();
        }
    }
}