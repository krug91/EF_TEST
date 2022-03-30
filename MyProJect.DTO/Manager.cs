using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.DTO
{
    public class Manager
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Engineer> Engineers { get; set; }
    }
}
