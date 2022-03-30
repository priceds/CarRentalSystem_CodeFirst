
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TripReview
    {
        public int FeedbackId { get; set; }
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public string FeedbackMsg { get; set; }

    }
}
