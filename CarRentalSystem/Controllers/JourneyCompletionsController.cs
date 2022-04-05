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
    public class JourneyCompletionsController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public JourneyCompletionsController(CarRentalDbContext context)
        {
            _context = context;
        }

        // GET: api/JourneyCompletions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JourneyCompletion>>> GetJourneys()
        {
            return await _context.Journeys.ToListAsync();
        }

        // GET: api/JourneyCompletions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JourneyCompletion>> GetJourneyCompletion(int id)
        {
            var journeyCompletion = await _context.Journeys.FindAsync(id);

            if (journeyCompletion == null)
            {
                return NotFound();
            }

            return journeyCompletion;
        }

        // PUT: api/JourneyCompletions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJourneyCompletion(int id, JourneyCompletion journeyCompletion)
        {
            if (id != journeyCompletion.JourneyId)
            {
                return BadRequest();
            }

            _context.Entry(journeyCompletion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JourneyCompletionExists(id))
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

        // POST: api/JourneyCompletions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JourneyCompletion>> PostJourneyCompletion(JourneyCompletion journeyCompletion)
        {
            _context.Journeys.Add(journeyCompletion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJourneyCompletion", new { id = journeyCompletion.JourneyId }, journeyCompletion);
        }

        // DELETE: api/JourneyCompletions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJourneyCompletion(int id)
        {
            var journeyCompletion = await _context.Journeys.FindAsync(id);
            if (journeyCompletion == null)
            {
                return NotFound();
            }

            _context.Journeys.Remove(journeyCompletion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JourneyCompletionExists(int id)
        {
            return _context.Journeys.Any(e => e.JourneyId == id);
        }
    }
}
