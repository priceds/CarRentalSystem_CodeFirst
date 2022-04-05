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
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        
        [HttpPost]
        [Route("AddCar")]
        public IActionResult AddCar(Car car)
        {
            try
            {
                return new ObjectResult(_carService.AddCar(car));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpPut]
        [Route("UpdateCar")]
        public IActionResult UpdateCar(Car car)
        {

            try
            {
                return new ObjectResult(_carService.UpdateCar(car));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpDelete]
        [Route("DeleteCar")]
        public IActionResult DeleteCar(int id)
        {

            try
            {
                return new ObjectResult(_carService.DeleteCar(id));
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        [HttpGet]
        [Route("GetOnlyFreeCars")]
        public async Task<IActionResult> GetOnlyFreeCars()
        {
            try
            {
                return new ObjectResult(await _carService.GetOnlyFreeCars());
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetAllCars")]
        public async Task<IActionResult> GetAllCars()
        {
            try
            {
                return new ObjectResult(await _carService.GetAllCars());
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
    }
}
