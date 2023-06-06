using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace docker_demo.Controllers;

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

    [HttpPost("writetofile/x")]
    public ActionResult<List<string>> WriteToFile(string x)
    {
        if (!System.IO.File.Exists("sentences.txt"))// create the file and write the param text
        {
            List<string> stringList = new List<string>();
            stringList!.Add(x);
            string stringsSerialized = JsonSerializer.Serialize(stringList);
            System.IO.File.WriteAllText("sentences.txt", stringsSerialized);
            List<string> sl = new List<string>();
            sl.Add(x);
            return Ok(sl);
        }
        else// open the file, read the contents into a List<string>, add the param string. write the List back to the file.
        {
            // read from the file into a string
            string stringText = System.IO.File.ReadAllText("sentences.txt");
            List<string>? stringList = JsonSerializer.Deserialize<List<string>>(stringText);
            stringList!.Add(x);
            string stringsSerialized = JsonSerializer.Serialize(stringList);
            System.IO.File.WriteAllText("sentences.txt", stringsSerialized);
            return Ok(stringList);
        }
    }

    [HttpGet("crash")]
    public ActionResult<int> CrashMe()
    {
        // I must use this to crash the program because .NET will automatically handle any exceptions.
        Environment.Exit(-1);
        return 1;

        // int[] xx = new int[] { 1, 2 };
        // for (int y = 0; y <= 3; y++)
        // {
        //     int x = xx[y];
        // }
    }



}
