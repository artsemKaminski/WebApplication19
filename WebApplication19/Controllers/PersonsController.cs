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
        private static readonly List<Person> persons = new List<Person>() { 
            new Person { Id = 1, Name = "Artsem", Age = 26 },
            new Person { Id = 2, Name = "Ivan", Age = 30 } 
            };

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return persons;
        }

        [HttpGet("{id}")]
        public Person Get([FromRoute] int id)
        {
            return persons.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Person value)
        {
            persons.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Person value)
        {
            var person = persons.FirstOrDefault(x => x.Id == id);
            person.Name = value.Name;
            person.Age = value.Age;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            persons.Remove(persons.FirstOrDefault(x => x.Id == id));
        }
    }
}
