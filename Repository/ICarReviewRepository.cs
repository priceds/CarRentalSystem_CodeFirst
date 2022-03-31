using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarReviewRepository
    {
        int AddCarReview(CarReview review);
        int DeleteCarReview(int reviewId);
        Task<IEnumerable<CarReview>> GetAllCarReview();
        Task<IEnumerable<CarReview>> GetCarSpecificReviews(int car_id);
    }
}
