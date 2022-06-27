using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.Tables
{
    public class Customer
    {
        public int Id { get; set; }

        public string customerName { get; set; }

        public string customerSurname { get; set; }

        public string companyName { get; set; }

        public int companyNumber { get; set; }

        public string Street { get; set; }

        public int streetNumber { get; set; }

        public string postCode { get; set; }

        public string City { get; set; }

        public string phoneNumber { get; set; }

        public string Mail { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
