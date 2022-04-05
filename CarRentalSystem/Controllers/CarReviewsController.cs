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
    public class CarReviewsController : ControllerBase
    {
        private readonly ICarReviewService _carReviewService;

        public CarReviewsController(ICarReviewService carReviewService)
        {
            _carReviewService = carReviewService;
        }

        
        [HttpPost]
        [Route("AddCarReview")]
        public IActionResult AddDriverReview(CarReview review)
        {

            try
            {
                return new ObjectResult(_carReviewService.AddCarReview(review));
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        
        [HttpDelete]
        [Route("DeleteCarReview/{review_id}")]
        public IActionResult DeleteCarReview(int review_id)
        {
            try
            {
                return new ObjectResult(_carReviewService.DeleteCarReview(review_id));
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        
        [HttpGet]
        [Route("GetAllCarReview")]
        public async Task<IActionResult> GetAllDriverReview()
        {
            try
            {
                return new ObjectResult(await _carReviewService.GetAllCarReview());
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        
        [HttpGet]
        [Route("GetCarSpecificReviews")]
        public async Task<IActionResult> GetDriverSpecificReviews(int id)
        {

            try
            {
                return new ObjectResult(await _carReviewService.GetCarSpecificReviews(id));
            }
            catch (Exception ex)
            {

                return null;
            }

        }



    }
}
