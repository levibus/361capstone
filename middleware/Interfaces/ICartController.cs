using Microsoft.AspNetCore.Mvc;
using _361capstone.Models;

namespace _361capstone.Controllers
{
    public interface ICartController
    {
        JsonResult Get(Cart cart);
        JsonResult Post(Cart cart);
        //JsonResult Put(int customerId, string firstName);
        JsonResult Delete(Cart cart);
    }
}