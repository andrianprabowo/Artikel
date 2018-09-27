using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Artikel.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Artikel.API.Controllers
{
    // http://localhost:5050/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly DataContext _context;
        public ContentController(DataContext context)
        {
            _context = context;
        }
        // GET api/con
        [HttpGet]
        public async Task<IActionResult> GetContens()
        {
            var contens = await _context.Contents.ToListAsync();

            return Ok(contens);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContent(int id)
        {
            var content = await _context.Contents.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(content);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
