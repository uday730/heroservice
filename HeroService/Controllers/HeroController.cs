using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HeroService.Model;

namespace HeroService.Controllers
{
    [Route("api/[controller]")]
    public class HeroController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Hero> Get()
        {

            return new Hero[] { new Hero { Id = 11, Name = "Mr. Nice" },
                new Hero { Id = 12, Name = "Narco" },
                new Hero { Id = 13, Name = "Bombasto" },
                new Hero { Id = 14, Name = "Celeritas" },
                new Hero { Id = 15, Name = "Magneta" },
                new Hero { Id = 16, Name = "RubberMan" },
                new Hero { Id = 17, Name = "Dynama" },
                new Hero { Id = 18, Name = "Dr IQ" },
                new Hero { Id = 19, Name = "Magma" },
                new Hero { Id = 20, Name = "Tornado" },
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
