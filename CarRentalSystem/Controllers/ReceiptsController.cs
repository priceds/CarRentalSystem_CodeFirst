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
    public class ReceiptsController : ControllerBase
    {
        private readonly IReceiptService _receiptService;

        public ReceiptsController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }
        
        [HttpPost]
        [Route("AddReceipt")]
        public IActionResult AddReceipt(Receipt receipt)
        {
            try
            {
                return new ObjectResult(_receiptService.AddReceipt(receipt));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpPut]
        [Route("UpdateReceipt")]
        public IActionResult UpdateReceipt(Receipt receipt)
        {

            try
            {
                return new ObjectResult(_receiptService.UpdateReceipt(receipt));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetAllReceipts")]
        public async Task<IActionResult> GetAllReceipts()
        {
            try
            {
                return new ObjectResult(await _receiptService.GetAllReceipts());
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }
        
        [HttpGet]
        [Route("GetAllReceipts/{id}")]
        public async Task<IActionResult> GetReceiptByBookingId(int id)
        {
            try
            {
                return new ObjectResult(await _receiptService.GetReceiptByBookingId(id));
            }
            catch (Exception ex)
            {

                
                return null;
            }

        }

    }
}
