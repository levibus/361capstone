using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361capstone.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int addressId { get; set; }
        public string cardNumber { get; set; }
        public string cardExp { get; set; }
        public int cardCVC { get; set; }
        public int cartId { get; set; }
    }
}