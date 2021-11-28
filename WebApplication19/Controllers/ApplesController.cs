using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    [ApiController]
    [Route("Person/{personId}/[controller]")]
    public class ApplesController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Apple> Get([FromRoute] int personId)
        {
            return StaticData.Persons.FirstOrDefault(x => x.Id == personId).Apples;
        }

        [HttpGet("{id}")]
        public Apple Get([FromRoute] int personId, [FromRoute] int id)
        {
            return StaticData.Persons.FirstOrDefault(x => x.Id == personId).Apples.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromRoute] int personId, [FromBody] Apple value)
        {
            StaticData.Persons.FirstOrDefault(x => x.Id == personId).Apples.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int personId, [FromRoute] int id, [FromBody] Apple value)
        {
            var apple = StaticData.Persons.FirstOrDefault(x => x.Id == personId).Apples.FirstOrDefault(x => x.Id == id);
            apple.Color = value.Color;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int personId, [FromRoute] int id)
        {
            var apples = StaticData.Persons.FirstOrDefault(x => x.Id == personId).Apples;
            apples.Remove(apples.FirstOrDefault(x => x.Id == id));
        }
    }
}
