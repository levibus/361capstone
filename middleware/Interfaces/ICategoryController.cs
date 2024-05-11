using Microsoft.AspNetCore.Mvc;

namespace _361capstone.Controllers
{
    public interface ICategoryController
    {
        JsonResult Get(int categoryId);
    }
}
