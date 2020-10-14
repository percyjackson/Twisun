using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Twisun.Web.Data;
using Twisun.Web.Data.Entities;

namespace Twisun.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RangesController : ControllerBase
    {
        private readonly DataContext _context;

        public RangesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Ranges
        [HttpGet]
        public IEnumerable<Range> GetRanges()
        {
            return _context.Ranges;
        }

        // GET: api/Ranges/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRange([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var range = await _context.Ranges.FindAsync(id);

            if (range == null)
            {
                return NotFound();
            }

            return Ok(range);
        }

        // PUT: api/Ranges/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRange([FromRoute] int id, [FromBody] Range range)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != range.Id)
            {
                return BadRequest();
            }

            _context.Entry(range).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RangeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ranges
        [HttpPost]
        public async Task<IActionResult> PostRange([FromBody] Range range)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ranges.Add(range);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRange", new { id = range.Id }, range);
        }

        // DELETE: api/Ranges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRange([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var range = await _context.Ranges.FindAsync(id);
            if (range == null)
            {
                return NotFound();
            }

            _context.Ranges.Remove(range);
            await _context.SaveChangesAsync();

            return Ok(range);
        }

        private bool RangeExists(int id)
        {
            return _context.Ranges.Any(e => e.Id == id);
        }
    }
}