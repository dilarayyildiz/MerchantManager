using MerchantApi.Model;
using MerchantApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MerchantApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User loginUser)
    {
        if (_userService.Login(loginUser.Username, loginUser.Password))
        {
            return Ok("Login successful");
        }

        return Unauthorized("Invalid credentials");
    }
}