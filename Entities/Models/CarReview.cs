using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CarReview
    {
        public int ReviewId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int BookingId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
    }
}
