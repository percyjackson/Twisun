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
    public class UsedCouponsController : ControllerBase
    {
        private readonly DataContext _context;

        public UsedCouponsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UsedCoupons
        [HttpGet]
        public IEnumerable<UsedCoupon> GetUsedCoupons()
        {
            return _context.UsedCoupons;
        }

        // GET: api/UsedCoupons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsedCoupon([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usedCoupon = await _context.UsedCoupons.FindAsync(id);

            if (usedCoupon == null)
            {
                return NotFound();
            }

            return Ok(usedCoupon);
        }

        // PUT: api/UsedCoupons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsedCoupon([FromRoute] int id, [FromBody] UsedCoupon usedCoupon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usedCoupon.Id)
            {
                return BadRequest();
            }

            _context.Entry(usedCoupon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsedCouponExists(id))
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

        // POST: api/UsedCoupons
        [HttpPost]
        public async Task<IActionResult> PostUsedCoupon([FromBody] UsedCoupon usedCoupon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UsedCoupons.Add(usedCoupon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsedCoupon", new { id = usedCoupon.Id }, usedCoupon);
        }

        // DELETE: api/UsedCoupons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsedCoupon([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usedCoupon = await _context.UsedCoupons.FindAsync(id);
            if (usedCoupon == null)
            {
                return NotFound();
            }

            _context.UsedCoupons.Remove(usedCoupon);
            await _context.SaveChangesAsync();

            return Ok(usedCoupon);
        }

        private bool UsedCouponExists(int id)
        {
            return _context.UsedCoupons.Any(e => e.Id == id);
        }
    }
}