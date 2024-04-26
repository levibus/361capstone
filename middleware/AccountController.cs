//using Microsoft.AspNetCore.Mvc;
//namespace _361capstone.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class AccountController : ControllerBase
//    {
//        [HttpPost("create")]
//        public IActionResult CreateAccount([FromBody] UserRegistration user)
//        {
//            if (string.IsNullOrWhiteSpace(user.Email))
//            {
//                return BadRequest("Email is required");
//            }            // Add logic to handle account creation, e.g., saving to a database            return Ok(new { message = "Account created successfully!" });
//            else { return; }
//        }

//    }
//    public class UserRegistration
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Email { get; set; }
//        public string Password { get; set; }
//    }
//}