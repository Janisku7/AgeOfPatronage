using AgeOfPatronage.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfPatronage.Server.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<Patronates> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 7).Select(index => new Patronates
            {
                Date = DateTime.Now.AddDays(index),
                Patron = rng.ToString(),
                
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
    }
}
