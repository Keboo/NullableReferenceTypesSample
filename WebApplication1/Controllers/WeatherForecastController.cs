using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherContext Context { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherContext context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpPost]
        public async Task CreateEvent(WeatherData weatherData)
        {
            Context.WeatherEvents.Add(new WeatherEvent
            {
                Title = weatherData.Name,
                Content = weatherData.Content ?? "Raining frogs and fish... probably"
            });
            await Context.SaveChangesAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await Context.Locations.ToListAsync();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
