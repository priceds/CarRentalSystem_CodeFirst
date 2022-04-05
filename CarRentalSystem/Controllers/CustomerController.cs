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

       

        [HttpGet]
        [Route("api/v1/GetCustomersWhoRActive")]
        //
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
        [HttpPost]
        [Route("api/v1/AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            return new ObjectResult(_customerService.AddCustomer(customer));

        }



    }
}
