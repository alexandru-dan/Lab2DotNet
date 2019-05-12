using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class DataSeeder
    {
        public static void Initialize(IntroDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Expensess.Any())
            {
                return;
            }

            context.Expensess.AddRange(
                new Expenses
                {
                    Description = "Titanic",
                    Sum = 17.20,
                    Location = "Cluj-Napoca",
                    Date = DateTime.Today,
                    Currency = "Lei",
                    Type = Type.Other
                },
                new Expenses
                {
                    Description = "Apa",
                    Sum = 7.20,
                    Location = "Cluj-Napoca",
                    Date = DateTime.Today,
                    Currency = "Lei",
                    Type = Type.Food
                });

        }
    }
}
