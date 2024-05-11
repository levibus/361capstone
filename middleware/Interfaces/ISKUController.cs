using Microsoft.AspNetCore.Mvc;
using _361capstone.Models;

namespace _361capstone.Controllers
{
    public interface ISKUController
    {
        JsonResult Get(Product prod);
    }
}
