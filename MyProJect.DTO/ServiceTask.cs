using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.DTO
{
    public class ServiceTask
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
