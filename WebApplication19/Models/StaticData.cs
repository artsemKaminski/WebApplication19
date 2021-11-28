using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19.Models
{
    public class StaticData
    {
        public static List<Person> Persons = new List<Person>() {
            new Person { Id = 1, Name = "Artsem", Age = 26, 
                Apples =  new List<Apple>() { 
                    new Apple{ Id = 1, Color = "White" }, 
                    new Apple { Id = 2, Color = "Red" } 
                    }
                },
            new Person { Id = 2, Name = "Ivan", Age = 30,
                Apples =  new List<Apple>() {
                    new Apple{ Id = 3, Color = "White" },
                    new Apple { Id = 4, Color = "Red" }
                    }
                }
            };
    }
}
