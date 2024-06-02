using Microsoft.AspNetCore.Mvc;
using Week7_ASPNET.Models;

namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class GreetingsController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Greetings, human!");
    }

    [HttpPost]
    public IActionResult Post(Message message)
    {
        System.Console.WriteLine(message.note);
        return Created();
    }
}