
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers;

[ApiController]
[Route("[controller]")]

public class AuthController : ControllerBase{
        
        [HttpPost("register")]
        public IActionResult Register(){
            return Ok("Register");
        }
    
        [HttpPost("login")]
        public IActionResult Login(){
            return Ok("Login");
        }
}