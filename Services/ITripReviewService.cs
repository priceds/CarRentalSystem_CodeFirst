using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITripReviewService
    {
        int CreateFeedBack(TripReview tripreview);
        Task<IEnumerable<TripReview>> GetAllTripReviews();
        Task<TripReview> GetFeedback(int booking_id);

    }
}
