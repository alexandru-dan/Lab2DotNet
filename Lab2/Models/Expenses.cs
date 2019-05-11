using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Sum { get; set; }
        public DateTime date { get; set; }
        public string currency { get; set; }
        public string type { get; set; }
    }
}
