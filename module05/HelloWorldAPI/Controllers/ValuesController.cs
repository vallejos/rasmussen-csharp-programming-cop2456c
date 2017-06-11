using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Greeting[] greetings = new Greeting[] {
            new Greeting { Id = 1, Salute = "Hello, World!", Locale = "en-us", Banner="en-us.jpg"},
            new Greeting { Id = 2, Salute = "Bonjour tout le monde!", Locale = "fr-fr", Banner="fr-fr.jpg"},
            new Greeting { Id = 3, Salute = "Hallo Welt!", Locale = "de-de", Banner="de-de.jpg"},
            new Greeting { Id = 4, Salute = "Hola Mundo!", Locale = "es-es", Banner="es-es.jpg"}
        };

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 3));

            int rnd1 = rnd.Next(0, greetings.Length);

            return Ok(greetings[rnd1]);
        }

    }
}
