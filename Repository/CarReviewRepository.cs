using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarReviewRepository : ICarReviewRepository
    {
        private readonly CarRentalDbContext _context;
        public CarReviewRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddCarReview(CarReview review)
        {
            _context.CarReviews.Add(review);
            _context.SaveChanges();
            return 1;
        }

        public int DeleteCarReview(int reviewId)
        {
            var CarReviewInDb = _context.CarReviews.Find(reviewId);
            _context.CarReviews.Remove(CarReviewInDb);
            _context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<CarReview>> GetAllCarReview()
        {
            return await _context.CarReviews.ToListAsync();
        }

        public async Task<IEnumerable<CarReview>> GetCarSpecificReviews(int car_id)
        {
            return await _context.CarReviews.Where(review => review.CarId == car_id).ToListAsync();
        }
    }
}
