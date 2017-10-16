using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IdeaManager_API.Controllers
{
    [Route("api/[controller]")]
    public class IdeasController : Controller
    {
        // GET api/Ideas
        [HttpGet]
        public string Get()
        {
            // Return random dummy data
            var json =
                        "[{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Moon Garcia\",\"title\": \"lorum pisesmin verum\"}," +
                        "{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Roach Brewer\",\"title\": \"lorum pisesmin verum\"}," +
                        "{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Barber Conrad\",\"title\": \"lorum pisesmin verum\"}," +
                        "{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Ross Tate\",\"title\": \"lorum pisesmin verum\"}," +
                        "{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Alexander Beasley\",\"title\": \"lorum pisesmin verum\"}," +
                        "{\"picture\": \"http://placehold.it/32x32\",\"name\": \"Hunter Michael\",\"title\": \"lorum pisesmin verum\"}]";           
            return json;

        }

        // GET api/Ideas/5
        [HttpGet("{id}")]
        public string[] Get(int id)
        {
            return new string[] {"Idea x title", "Idea x Description"};
        }

        // POST api/Ideas
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Ideas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Ideas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
