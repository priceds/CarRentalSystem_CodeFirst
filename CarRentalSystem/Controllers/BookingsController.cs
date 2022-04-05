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
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        [Route("AddBooking")]
        public IActionResult AddBooking(Booking booking)
        {
            try
            {
                return new ObjectResult(_bookingService.AddBooking(booking));
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        
        [HttpPut]
        [Route("ModifyBooking")]
        public IActionResult ModifyBooking(Booking booking)
        {

            try
            {
                return new ObjectResult(_bookingService.ModifyBooking(booking));
            }
            catch (Exception ex)
            {
                
                return new ObjectResult("Some Error Occured");
            }


        }
        
        [HttpDelete]
        [Route("DeleteBooking/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                return new ObjectResult(_bookingService.DeleteBooking(id));
            }
            catch (Exception ex)
            {
                
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetAllBookings")]
        public async Task<IActionResult> GetAllBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetAllPendingBookings")]
        public async Task<IActionResult> GetAllPendingBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllPendingBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetAllConfirmedBookings")]
        public async Task<IActionResult> GetAllConfirmedBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllConfirmedBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetAllBookingForCustomerWithId/{id}")]
        public async Task<IActionResult> GetAllBookingForCustomerWithId(int id)
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllBookingForCustomerWithId(id));
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetPastWeekBookings")]
        public async Task<IActionResult> GetPastWeekBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetPastWeekBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetPastMonthBookings")]
        public async Task<IActionResult> GetPastMonthBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetPastMonthBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetPastSixMonthBookings")]
        public async Task<IActionResult> GetPastSixMonthBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetPastSixMonthBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetPastYearBookings")]
        public async Task<IActionResult> GetPastYearBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetPastYearBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }

        
        [HttpGet]
        [Route("GetAllJourneyCompletedBookings")]
        public async Task<IActionResult> GetAllJourneyCompletedBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllJourneyCompletedBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }


        }

        
        [HttpGet]
        [Route("GetAllPaymentCompletedBookings")]
        public async Task<IActionResult> GetAllPaymentCompletedBookings()
        {
            try
            {
                return new ObjectResult(await _bookingService.GetAllPaymentCompletedBookings());
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }

    }
}
