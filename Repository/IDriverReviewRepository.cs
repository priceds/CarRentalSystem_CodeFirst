using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDriverReviewRepository
    {
        int AddDriverReview(DriverReview review);
        int DeleteDriverReview(int reviewId);
        Task<IEnumerable<DriverReview>> GetAllDriverReview();
        Task<IEnumerable<DriverReview>> GetDriverSpecificReviews(int driver_id);
    }
}
