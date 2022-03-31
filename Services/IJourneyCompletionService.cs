using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IJourneyCompletionService
    {
        int AddJourneyCompletion(JourneyCompletion completion);
        int UpdateJourneyCompletion(JourneyCompletion completion);
        Task<IEnumerable<JourneyCompletion>> GetAllJourneyCompletion();
        Task<JourneyCompletion> GetJourneyCompletionForBookingID(int id);
    }
}
