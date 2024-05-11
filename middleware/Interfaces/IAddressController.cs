using Microsoft.AspNetCore.Mvc;
using _361capstone.Models;

namespace _361capstone.Controllers
{
    public interface IAddressesController
    {
        JsonResult Get(Customer cust);
        //JsonResult Post(string firstName, string lastName, string username, string password);
        //JsonResult Put(int customerId, string firstName);
        //JsonResult Delete(int customerId);
    }
}
