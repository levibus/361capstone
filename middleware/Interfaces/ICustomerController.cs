using Microsoft.AspNetCore.Mvc;
using System.Data;
using _361capstone.Models;

namespace _361capstone.Controllers
{
    public interface ICustomerController
    {
        JsonResult Get(string username, string password);
        JsonResult Post(Customer cust);
        //JsonResult Put(int customerId, string firstName);
        //JsonResult Delete(int customerId);
    }
}
