using LoginAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserSController : ControllerBase{
    private readonly IUserService _userService;
    public UsersSController(IUserService userService)
    {
        _userService = userService;
    }
}