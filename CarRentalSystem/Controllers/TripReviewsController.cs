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
    public class TripReviewsController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public TripReviewsController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/TripReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripReview>>> GetTripReviews()
        {
            return await _context.TripReviews.ToListAsync();
        }

        // GET: api/TripReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripReview>> GetTripReview(int id)
        {
            var tripReview = await _context.TripReviews.FindAsync(id);

            if (tripReview == null)
            {
                return NotFound();
            }

            return tripReview;
        }

        // PUT: api/TripReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTripReview(int id, TripReview tripReview)
        {
            if (id != tripReview.FeedbackId)
            {
                return BadRequest();
            }

            _context.Entry(tripReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TripReviewExists(id))
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

        // POST: api/TripReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TripReview>> PostTripReview(TripReview tripReview)
        {
            _context.TripReviews.Add(tripReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTripReview", new { id = tripReview.FeedbackId }, tripReview);
        }

        // DELETE: api/TripReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTripReview(int id)
        {
            var tripReview = await _context.TripReviews.FindAsync(id);
            if (tripReview == null)
            {
                return NotFound();
            }

            _context.TripReviews.Remove(tripReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TripReviewExists(int id)
        {
            return _context.TripReviews.Any(e => e.FeedbackId == id);
        }
    }
}
