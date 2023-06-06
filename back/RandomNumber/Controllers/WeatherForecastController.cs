using Microsoft.AspNetCore.Mvc;

namespace RandomNumber.Controllers;

[ApiController]
[Route("[controller]")]
public class RandomNumber : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {

        return Ok(GenerateRandom());
    }

    private int GenerateRandom()
    {
        Random random = new Random();
        return random.Next(1, 100);
    }
}
