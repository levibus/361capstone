using Microsoft.AspNetCore.Mvc;

namespace _361capstone.Controllers
{
    public interface ISearchController
    {
        JsonResult Get(int customerId);
    }
}
