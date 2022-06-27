using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.Tables
{
    public class Employee
    {
        public int Id { get; set; }

        public string employeeName { get; set; }

        public string employeeSurname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public decimal employeeBonus { get; set; }
    }
}
