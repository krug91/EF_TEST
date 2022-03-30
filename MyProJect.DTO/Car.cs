using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.DTO
{

    public enum Brand { Toyota, Nisssan, Audi}

    public class Car
    {
        public Guid ID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
