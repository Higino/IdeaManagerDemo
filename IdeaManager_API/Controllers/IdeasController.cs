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
        public IEnumerable<string> Get()
        {
            return new string[] { "Idea1 Title", "Idea 1 Description" };
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
