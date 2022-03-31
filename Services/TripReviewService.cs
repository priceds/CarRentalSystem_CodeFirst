using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TripReviewService:ITripReviewService
    {
        private readonly ITripReviewRepository _tripReviewRepository;
        public TripReviewService(ITripReviewRepository tripReviewRepository)
        {
            _tripReviewRepository = tripReviewRepository;
        }

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
