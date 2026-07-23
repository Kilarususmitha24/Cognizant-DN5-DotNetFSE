using JwtAuthApi.Models;
using JwtAuthApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        private static readonly List<User> users = new()
        {
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                Role = "Admin"
            },
            new User
            {
                Id = 2,
                Username = "user",
                Password = "user123",
                Role = "User"
            }
        };

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            var user = users.FirstOrDefault(x =>
                x.Username == login.Username &&
                x.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Username or Password");
            }

            var token = _jwtService.GenerateToken(user);

            return Ok(new
            {
                Token = token
            });
        }
    }
}
