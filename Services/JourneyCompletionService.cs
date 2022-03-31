using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class JourneyCompletionService:IJourneyCompletionService
    {
        private readonly IJourneyCompletionRepository _journeyCompletionRepository;
        public JourneyCompletionService(IJourneyCompletionRepository journeyCompletionRepository)
        {
            _journeyCompletionRepository = journeyCompletionRepository;
        }

        public int AddJourneyCompletion(JourneyCompletion completion)
        {
            return _journeyCompletionRepository.AddJourneyCompletion(completion);
        }

        public Task<IEnumerable<JourneyCompletion>> GetAllJourneyCompletion()
        {
            return _journeyCompletionRepository.GetAllJourneyCompletion();
        }

        public Task<JourneyCompletion> GetJourneyCompletionForBookingID(int id)
        {
            return _journeyCompletionRepository.GetJourneyCompletionForBookingID(id);
        }

        public int UpdateJourneyCompletion(JourneyCompletion completion)
        {
            return _journeyCompletionRepository.UpdateJourneyCompletion(completion);
        }
    }
}
