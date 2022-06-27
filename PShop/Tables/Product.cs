using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PShop.Tables
{
    public class Product
    {
        public int Id { get; set; }

        public string productName { get; set; }

        public int availablePieces { get; set; }

        public decimal netPrice { get; set; }

        public decimal netSellingPrice { get; set; }

    }
}
