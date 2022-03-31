using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarReviewService : ICarReviewService
    {
        private readonly ICarReviewRepository _carReviewRepository;
        public CarReviewService(ICarReviewRepository carReviewRepository)
        {
            _carReviewRepository = carReviewRepository;
        }
        public int AddCarReview(CarReview review)
        {
            return _carReviewRepository.AddCarReview(review);
        }

        public int DeleteCarReview(int reviewId)
        {
            return _carReviewRepository.DeleteCarReview(reviewId);
        }

        public Task<IEnumerable<CarReview>> GetAllCarReview()
        {
            return _carReviewRepository.GetAllCarReview();
        }

        public Task<IEnumerable<CarReview>> GetCarSpecificReviews(int car_id)
        {
            return _carReviewRepository.GetCarSpecificReviews(car_id);
        }
    }
}
