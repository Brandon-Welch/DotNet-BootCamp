using Microsoft.AspNetCore.Mvc;

namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class GoodByeController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Goodbye, human!");
    }
}