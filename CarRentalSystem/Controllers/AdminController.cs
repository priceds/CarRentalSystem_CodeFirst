using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        [Route("api/v1/CheckIfAdminIsValid")]
        public IActionResult CheckIfAdminIsValid(string email,string password)
        {

            return new ObjectResult(_adminService.CheckIfAdminisValid(email, password));

        }



    }
}
