using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TripReviewRepository : ITripReviewRepository
    {
        public int CreateFeedBack(TripReview tripreview)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TripReview>> GetAllTripReviews()
        {
            throw new NotImplementedException();
        }

        public Task<TripReview> GetFeedback(int booking_id)
        {
            throw new NotImplementedException();
        }
    }
}
