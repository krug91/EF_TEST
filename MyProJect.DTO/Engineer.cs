using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.DTO
{
    public class Engineer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal SalaryPerMonth { get; set; }

    }
}
