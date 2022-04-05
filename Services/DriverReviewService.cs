using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DriverReviewService : IDriverReviewService
    {
        private readonly IDriverReviewRepository _driverReviewRepository;
        public DriverReviewService(IDriverReviewRepository driverReviewRepository)
        {
            _driverReviewRepository = driverReviewRepository;
        }
        public int AddDriverReview(DriverReview review)
        {
            return _driverReviewRepository.AddDriverReview(review);
        }

        public int DeleteDriverReview(int reviewId)
        {
            return _driverReviewRepository.DeleteDriverReview(reviewId);
        }

        public Task<IEnumerable<DriverReview>> GetAllDriverReview()
        {
            return _driverReviewRepository.GetAllDriverReview();
        }

        public Task<IEnumerable<DriverReview>> GetDriverSpecificReviews(int driver_id)
        {
            return _driverReviewRepository.GetDriverSpecificReviews(driver_id);
        }
    }
}
