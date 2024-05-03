using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361capstone.Models
{
    public class Cart
    {
        public int cartId { get; set; }
        public int customerId { get; set; }
        public string firstName { get; set; }
        public int SKU { get; set; }
        public int Quantity { get; set; }
     
    }
}