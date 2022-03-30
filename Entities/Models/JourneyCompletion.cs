using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class JourneyCompletion
    {
        public int JourneyId { get; set; }
        public int? BookingId { get; set; }
        public int? DriverId { get; set; }
        public decimal? KmDone { get; set; }
        public decimal? TotalFare { get; set; }



    }
}
