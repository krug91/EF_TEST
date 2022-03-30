using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.DTO
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Tin { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
