using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    internal static class AccountsLoader
    {
        public static void LoadAccounts(DataContext context)
        {
            var swedbank = context.Institutions.GetByName("SWEDBANK");
            var lhv = context.Institutions.GetByName("LHV");

            context.Accounts.Add(new Account { AccountNo = "234234234", Name = "Põhikonto", Institution = swedbank });
            context.Accounts.Add(new Account { AccountNo = "345645633", Name = "LHV arvelduskonto", Institution = lhv });
            context.Accounts.Add(new Account { AccountNo = "236554211", Name = "LHV kasvukonto", Institution = lhv });
            context.Accounts.Add(new Account { AccountNo = "973647626", Name = "LHV väärtpaberikonto", Institution = lhv });
        }
    }
}
