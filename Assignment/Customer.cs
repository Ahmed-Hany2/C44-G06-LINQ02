using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<Order> Orders { get; set; }
    }

}
