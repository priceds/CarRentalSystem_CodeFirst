using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class JourneyCompletion
    {
        public int JourneyId { get; set; }

        [Required]
        [ForeignKey("BookingId")]
        public int? BookingId { get; set; }
        public virtual Booking BookingID { get; set; }
        [Required]
        [ForeignKey("DriverId")]
        public int? DriverId { get; set; }
        public virtual Driver DriverID { get; set; }
        [Required]
        public decimal? KmDone { get; set; }
        [Required]
        public decimal? TotalFare { get; set; }



    }
}
