using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int? BookingId { get; set; }
        public int? JourneyId { get; set; }
        public decimal? TotalFare { get; set; }
        public string PaymentStatus { get; set; }



    }
}
