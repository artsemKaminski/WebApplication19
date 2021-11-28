using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplesController : ControllerBase
    {
        private static List<Apple> apples = new List<Apple>() { new Apple{ Id = 1, Color = "White" }, new Apple { Id = 2, Color = "Red" } };

        [HttpGet]
        public IEnumerable<Apple> Get()
        {
            return apples;
        }

        [HttpGet("{id}")]
        public Apple Get([FromRoute] int id)
        {
            return apples.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Apple value)
        {
            apples.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Apple value)
        {
            var apple = apples.FirstOrDefault(x => x.Id == id);
            apple.Color = value.Color;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            apples.Remove(apples.FirstOrDefault(x => x.Id == id));
        }
    }
}
