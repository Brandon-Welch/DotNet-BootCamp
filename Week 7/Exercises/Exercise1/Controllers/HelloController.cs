using Microsoft.AspNetCore.Mvc;
using Week7_Exercise1.Models;

namespace Week7_Exercise1.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }

    [HttpPost]
    public IActionResult Post(Message message)
    {
        System.Console.WriteLine(message.note);
        return Created();
    }
}