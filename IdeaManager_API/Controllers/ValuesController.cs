using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IdeaManager_API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var RegisteredUsers = new List<Idea>();
            RegisteredUsers.Add(new Idea() { Title = "Duis bibendum", Name = "Bryon Hetrick" });
            RegisteredUsers.Add(new Idea() { Title = "Donec semper sapien a libero", Name = "Nicole Wilcox" });
            RegisteredUsers.Add(new Idea() { Title = "Sed ante", Name = "Adrian Martinson" });
            RegisteredUsers.Add(new Idea() { Title = "Sed ante blessum", Name = "Nora Osborn" });

            string json = JsonConvert.SerializeObject(RegisteredUsers);
            return json;
            //return new string[] { "value1", "value2" };
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

namespace IdeaManager_API.Controllers
{
    public class Idea
    {
        public string Title { get; set; }
        public string Name { get; set; }
    }
}