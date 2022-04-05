using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repository;
using Services;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverReviewsController : ControllerBase
    {
        private readonly IDriverReviewService _driverReviewService;

        public DriverReviewsController(IDriverReviewService driverReviewService)
        {
            _driverReviewService = driverReviewService;
        }

        
        [HttpPost]
        [Route("AddDriverReview")]
        public IActionResult AddDriverReview(DriverReview review)
        {

            try
            {
                return new ObjectResult(_driverReviewService.AddDriverReview(review));
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }
        
        [HttpDelete]
        [Route("DeleteDriverReview/{review_id}")]
        public IActionResult DeleteDriverReview(int review_id)
        {
            try
            {
                return new ObjectResult(_driverReviewService.DeleteDriverReview(review_id));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetAllDriverReview")]
        public async Task<IActionResult> GetAllDriverReview()
        {
            try
            {
                return new ObjectResult(await _driverReviewService.GetAllDriverReview());
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        
        [HttpGet]
        [Route("GetDriverSpecificReviews")]
        public async Task<IActionResult> GetDriverSpecificReviews(int id)
        {

            try
            {
                return new ObjectResult(await _driverReviewService.GetDriverSpecificReviews(id));
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }

    }
}
