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
    public class JourneyCompletionsController : ControllerBase
    {
        private readonly IJourneyCompletionService _journeyCompletionService;

        public JourneyCompletionsController(IJourneyCompletionService journeyCompletionService)
        {
            _journeyCompletionService = journeyCompletionService;
        }

        
        [HttpPost]
        [Route("AddJourneyCompletion")]
        public IActionResult AddJourneyCompletion(JourneyCompletion completion)
        {
            try
            {
                return new ObjectResult(_journeyCompletionService.AddJourneyCompletion(completion));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetAllJourneyCompletion")]
        public async Task<IActionResult> GetAllJourneyCompletion()
        {
            try
            {
                return new ObjectResult(await _journeyCompletionService.GetAllJourneyCompletion());
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetJourneyCompletionForBookingID/{id}")]
        public async Task<IActionResult> GetJourneyCompletionForBookingID(int id)
        {
            try
            {
                return new ObjectResult(await _journeyCompletionService.GetJourneyCompletionForBookingID(id));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpPut]
        [Route("UpdateJourneyCompletion")]
        public IActionResult UpdateJourneyCompletion(JourneyCompletion completion)
        {

            try
            {
                return new ObjectResult(_journeyCompletionService.UpdateJourneyCompletion(completion));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }

    }
}
