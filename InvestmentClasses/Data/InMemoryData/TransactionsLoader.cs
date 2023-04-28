using System;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    public static class TransactionsLoader
    {
        public static void LoadTransactions(DataContext context)
        {
            Pohikonto20230401(context); // Põhikonto rahade liikumine 01.04.2023
            Arvelduskonto345645633(context); // Arvelduskonto rahade liikumine 01.04.2023
            Kasvukonto236554211(context); // Kasvukonto rahade liikumine 01.04.2023
            Väärtpaberikonto973647626(context); // Väärtpaberikonto rahade liikumine 01.04.2023
        }

        private static void Pohikonto20230401(DataContext context)
        {
            var swed = context.Accounts.GetByName("Põhikonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -20m,
                Securable = eur,
                Description = "PRISMA POS/XSD/9393873/9392" // Kommid
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -5m,
                Securable = eur,
                Description = "Ülekanne sõbrale" // Raha sõbrale
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -15m,
                Securable = eur,
                Description = "Arve B837378992/353535" // Telefoniarve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            swed.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == swed));
        }

        private static void Arvelduskonto345645633(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV arvelduskonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 200m,
                Securable = eur,
                Description = "Arvelduseks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = -80m,
                Securable = eur,
                Description = "Vee arve 2023-04"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -50m,
                Securable = eur,
                Description = "Elektri arve"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void Kasvukonto236554211(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV kasvukonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-06-01 10:00:00"),
                Amount = 20m,
                Securable = eur,
                Description = "Kasvuks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-07-01 10:00:00"),
                Amount = 20m,
                Securable = eur,
                Description = "Kasvuks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-08-01 10:00:00"),
                Amount = 20m,
                Securable = eur,
                Description = "Kasvuks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-09-01 10:00:00"),
                Amount = 20m,
                Securable = eur,
                Description = "Kasvuks"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void Väärtpaberikonto973647626(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV väärtpaberikonto");
            var eur = context.Securables.GetByTicker("EUR");


            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 500m,
                Securable = eur,
                Description = "Aktsiate ostmiseks"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = -200m,
                Securable = eur,
                Description = "Tesla aktsiad"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -50m,
                Securable = eur,
                Description = "Amazon aktsiad"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -90m,
                Securable = eur,
                Description = "Apple aktsiad" // Telefoniarve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }
    }
}
