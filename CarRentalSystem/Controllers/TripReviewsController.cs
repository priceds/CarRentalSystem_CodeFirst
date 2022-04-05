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
    public class TripReviewsController : ControllerBase
    {
        private readonly ITripReviewService _tripReviewService;

        public TripReviewsController(ITripReviewService tripReviewService)
        {
            _tripReviewService = tripReviewService;
        }

        
        [HttpGet]
        [Route("CreateFeedBack")]
        public IActionResult CreateFeedBack(TripReview feedback)
        {
            try
            {
                return new ObjectResult(_tripReviewService.CreateFeedBack(feedback));

            }
            catch (Exception ex)
            {

               
                return null;
            }

        }

        
        [HttpGet]
        [Route("GetAllFeedbacks")]
        public async Task<IActionResult> GetAllFeedbacks()
        {
            try
            {
                return new ObjectResult(await _tripReviewService.GetAllTripReviews());

            }
            catch (Exception ex)
            {

               
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetFeedback/{booking_id}")]
        public async Task<IActionResult> GetFeedback(int booking_id)
        {
            try
            {
                return new ObjectResult(await _tripReviewService.GetFeedback(booking_id));

            }
            catch (Exception ex)
            {

               
                return null;
            }

        }
    }
}
