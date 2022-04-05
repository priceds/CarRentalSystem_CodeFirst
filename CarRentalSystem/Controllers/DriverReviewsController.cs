using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repository;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverReviewsController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public DriverReviewsController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/DriverReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverReview>>> GetDriverReviews()
        {
            return await _context.DriverReviews.ToListAsync();
        }

        // GET: api/DriverReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DriverReview>> GetDriverReview(int id)
        {
            var driverReview = await _context.DriverReviews.FindAsync(id);

            if (driverReview == null)
            {
                return NotFound();
            }

            return driverReview;
        }

        // PUT: api/DriverReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriverReview(int id, DriverReview driverReview)
        {
            if (id != driverReview.ReviewId)
            {
                return BadRequest();
            }

            _context.Entry(driverReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverReviewExists(id))
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

        // POST: api/DriverReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DriverReview>> PostDriverReview(DriverReview driverReview)
        {
            _context.DriverReviews.Add(driverReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDriverReview", new { id = driverReview.ReviewId }, driverReview);
        }

        // DELETE: api/DriverReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriverReview(int id)
        {
            var driverReview = await _context.DriverReviews.FindAsync(id);
            if (driverReview == null)
            {
                return NotFound();
            }

            _context.DriverReviews.Remove(driverReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DriverReviewExists(int id)
        {
            return _context.DriverReviews.Any(e => e.ReviewId == id);
        }
    }
}
