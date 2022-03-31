using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DriverReviewRepository : IDriverReviewRepository
    {
        private readonly CarRentalDbContext _context;
        public DriverReviewRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddDriverReview(DriverReview review)
        {
            _context.DriverReviews.Add(review);
           return _context.SaveChanges();
        }

        public int DeleteDriverReview(int reviewId)
        {
            var DriverReviewInDb = _context.DriverReviews.Find(reviewId);
            _context.Remove(DriverReviewInDb);
            return _context.SaveChanges();
        }

        public async Task<IEnumerable<DriverReview>> GetAllDriverReview()
        {
            return await _context.DriverReviews.ToListAsync();
        }

        public async Task<IEnumerable<DriverReview>> GetDriverSpecificReviews(int driver_id)
        {
            return await _context.DriverReviews.Where(review => review.DriverId == driver_id).ToListAsync();
        }
    }
}
