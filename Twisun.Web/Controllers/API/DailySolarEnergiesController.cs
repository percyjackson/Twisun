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
    public class DailySolarEnergiesController : ControllerBase
    {
        private readonly DataContext _context;

        public DailySolarEnergiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DailySolarEnergies
        [HttpGet]
        public IEnumerable<DailySolarEnergy> GetDailySolarEnergies()
        {
            return _context.DailySolarEnergies;
        }

        // GET: api/DailySolarEnergies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDailySolarEnergy([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dailySolarEnergy = await _context.DailySolarEnergies.FindAsync(id);

            if (dailySolarEnergy == null)
            {
                return NotFound();
            }

            return Ok(dailySolarEnergy);
        }

        // PUT: api/DailySolarEnergies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailySolarEnergy([FromRoute] int id, [FromBody] DailySolarEnergy dailySolarEnergy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dailySolarEnergy.Id)
            {
                return BadRequest();
            }

            _context.Entry(dailySolarEnergy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailySolarEnergyExists(id))
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

        // POST: api/DailySolarEnergies
        [HttpPost]
        public async Task<IActionResult> PostDailySolarEnergy([FromBody] DailySolarEnergy dailySolarEnergy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DailySolarEnergies.Add(dailySolarEnergy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDailySolarEnergy", new { id = dailySolarEnergy.Id }, dailySolarEnergy);
        }

        // DELETE: api/DailySolarEnergies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDailySolarEnergy([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dailySolarEnergy = await _context.DailySolarEnergies.FindAsync(id);
            if (dailySolarEnergy == null)
            {
                return NotFound();
            }

            _context.DailySolarEnergies.Remove(dailySolarEnergy);
            await _context.SaveChangesAsync();

            return Ok(dailySolarEnergy);
        }

        private bool DailySolarEnergyExists(int id)
        {
            return _context.DailySolarEnergies.Any(e => e.Id == id);
        }
    }
}