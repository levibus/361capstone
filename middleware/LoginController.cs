using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginAccessor _loginAccessor; public LoginController()
        {
            _loginAccessor = new LoginAccessor();  // Ideally, you'd inject this
        }
        [HttpPost("login")]
        public ActionResult<int> Login(string username, string password)
        {
            int result = _loginAccessor.accessLoginInformation(username, password);
            if (result == -1)
            {
                return NotFound("User not found");
            }
            else if (result == -2)
            {
                return StatusCode(500, "Database connection error");
            }
            return Ok(result);
        }
    }
}