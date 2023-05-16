using Microsoft.AspNetCore.Mvc;
using RpsApiBusiness;
using RpsApiModels;

namespace RpsApiGameApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost("PostNewPerson")]
    public int Test(string fname, string lname, string email)
    {
        int ret = RPS_GamePlay.Test(fname, lname, email);
        return ret;
    }


    [HttpGet("Login")]
    public Person Login(string fname, string lname)
    {
        Person ret = RPS_GamePlay.Login(fname, lname);
        return ret;
    }




}
