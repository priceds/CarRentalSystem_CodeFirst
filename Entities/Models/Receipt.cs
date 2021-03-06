using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }
     
        [ForeignKey("BookingId")]
        public int? BookingId { get; set; }
        public virtual Booking BookingID { get; set; }

     
        [ForeignKey("JourneyId")]
        public int? JourneyId { get; set; }
        public virtual JourneyCompletion JourneyID { get; set; }

        [Required]
        public decimal? TotalFare { get; set; }
        [Required]
        public string PaymentStatus { get; set; }



    }
}
