using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return StaticData.Persons;
        }

        [HttpGet("{id}")]
        public Person Get([FromRoute] int id)
        {
            return StaticData.Persons.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Person value)
        {
            StaticData.Persons.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Person value)
        {
            var person = StaticData.Persons.FirstOrDefault(x => x.Id == id);
            person.Name = value.Name;
            person.Age = value.Age;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            StaticData.Persons.Remove(StaticData.Persons.FirstOrDefault(x => x.Id == id));
        }
    }
}
