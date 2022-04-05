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
    public class DriversController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriversController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        
        [HttpPost]
        [Route("AddDriver")]
        public IActionResult AddDriver(Driver driver)
        {
            try
            {
                return new ObjectResult(_driverService.AddDriver(driver));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpPut]
        [Route("UpdateDriver")]
        public IActionResult UpdateCar(Driver driver)
        {

            try
            {
                return new ObjectResult(_driverService.UpdateDriver(driver));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpDelete]
        [Route("DeleteDriver")]
        public IActionResult DeleteDriver(int id)
        {

            try
            {
                return new ObjectResult(_driverService.DeleteDriver(id));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetOnlyFreeDrivers")]
        public async Task<IActionResult> GetOnlyFreeDrivers()
        {
            try
            {
                return new ObjectResult(await _driverService.GetOnlyFreeDrivers());
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetAllDrivers")]
        public async Task<IActionResult> GetAllDrivers()
        {
            try
            {
                return new ObjectResult(await _driverService.GetAllDrivers());
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        [HttpGet]
        [Route("CheckIfDriverisValid/{email}/{password}")]
        public async Task<IActionResult> CheckIfDriverisValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _driverService.CheckIfDriverisValid(email, password));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
    }
}
