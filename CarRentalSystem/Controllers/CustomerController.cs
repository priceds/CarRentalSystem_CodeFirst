using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Threading.Tasks;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        [Route("api/v1/GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {

            return new ObjectResult(_customerService.GetAllCustomers());

        }

        
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomers(Customer customer)
        {
            try
            {
                return new ObjectResult(_customerService.AddCustomer(customer));
            }
            catch (Exception ex)
            {
              
                return null;
            }


        }

        
        [HttpGet]
        [Route("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                return new ObjectResult(await _customerService.GetAllCustomers());
            }
            catch (Exception ex)
            {

              
                return null;
            }


        }


        [HttpGet]
        [Route("CheckIfCustomerIsValid/{email}/{password}")]
        public async Task<IActionResult> CheckIfCustomerIsValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _customerService.CheckIfCustomerIsValid(email, password));
            }
            catch (Exception ex)
            {
              
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetCustomer/{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            try
            {
                return new ObjectResult(await _customerService.GetCustomer(id));
            }
            catch (Exception ex)
            {

              
                return null;
            }


        }
        
        [HttpGet]
        [Route("GetCustomersWhoRActive")]
        public async Task<IActionResult> GetCustomersWhoRActive()
        {
            try
            {
                return new ObjectResult(await _customerService.GetCustomersWhoRActive());
            }
            catch (Exception ex)
            {

              
                return null;
            }


        }
        
        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {

            try
            {
                return new ObjectResult(_customerService.UpdateCustomer(customer));
            }
            catch (Exception ex)
            {

              
                return null;
            }
        }
        
        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            try
            {
                return new ObjectResult(_customerService.DeleteCustomer(id));
            }
            catch (Exception ex)
            {

              
                return null;
            }
        }





    }
}
