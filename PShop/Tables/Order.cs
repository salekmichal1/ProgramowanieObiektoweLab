using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.Tables
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime orderDate { get; set; }

        public bool orderFulfilled { get; set; }

        public int customerId { get; set; }

        public int employeeId { get; set; }

        public Employee? Employee { get; set; }
        
        public Customer? Customer { get; set; }

    }
}
