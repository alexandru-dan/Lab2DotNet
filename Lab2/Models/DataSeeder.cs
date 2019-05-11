using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class DataSeeder
    {
        public static void Initalize(IntroDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Expenses.Any())
            {
                return;
            }
        }
    }
}
