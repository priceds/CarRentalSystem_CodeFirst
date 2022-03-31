using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITripReviewRepository
    {
        int CreateFeedBack(TripReview tripreview);
        Task<IEnumerable<TripReview>> GetAllTripReviews();
        Task<TripReview> GetFeedback(int booking_id);
    }
}
