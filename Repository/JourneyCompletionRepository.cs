using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class JourneyCompletionRepository : IJourneyCompletionRepository

    {

        private readonly CarRentalDbContext _context;
        public JourneyCompletionRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddJourneyCompletion(JourneyCompletion completion)
        {
            _context.Journeys.Add(completion);
            return _context.SaveChanges();
        }

        public async Task<IEnumerable<JourneyCompletion>> GetAllJourneyCompletion()
        {
            return await _context.Journeys.ToListAsync();
        }

        public async Task<JourneyCompletion> GetJourneyCompletionForBookingID(int id)
        {
            return await _context.Journeys.Where(journey => journey.BookingId == id).SingleOrDefaultAsync();
        }

        public int UpdateJourneyCompletion(JourneyCompletion completion)
        {
            throw new NotImplementedException();
        }
    }
}
