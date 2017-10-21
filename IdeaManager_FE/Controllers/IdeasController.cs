using Microsoft.AspNetCore.Mvc;
using IdeaManager_FE.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace IdeaManager_API.Controllers
{
    [Route("api/[controller]")]
    public class IdeasController : Controller
    {
        private readonly IdeaContext _context;
    
        public IdeasController(IdeaContext context)
        {
            _context = context;

            if (_context.IdeaItems.Count() == 0)
            {
                _context.IdeaItems.Add(new Idea { Title = "Sample Idea", Author = "Test User", IdeaDate = DateTime.Now });
                _context.SaveChanges();
            }
        }

        // GET api/Ideas
        [HttpGet]
        public IEnumerable<Idea> Get()
        {
            return _context.IdeaItems.ToList();

        }

        // GET api/Ideas/5
        [HttpGet("{id}", Name = "GetIdea")]
        public IActionResult Get(int id)
        {
            System.Diagnostics.Debug.WriteLine("**************** Invoking GET ******************");
            var item = _context.IdeaItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/Ideas
        [HttpPost]
        public IActionResult Post([FromBody]Idea idea)
        {
            System.Diagnostics.Debug.WriteLine("**************** Invoking POST ******************");
            if (idea == null)
            {
                return BadRequest();
            }

            _context.IdeaItems.Add(idea);
            _context.SaveChanges();

            return CreatedAtRoute("GetIdea", new { id = idea.Id }, idea);
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
