using Microsoft.AspNetCore.Mvc;

namespace YourWebApiNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        @
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Perform authentication logic here
            if (request.Username == "admin" && request.Password == "password")
            {
                // Authentication successful
                return Ok(new { message = "Login successful" });
            }
            else
            {
                // Authentication failed
                return Unauthorized(new { message = "Invalid username or password" });
            }
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
