
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TripReview
    {
        public int FeedbackId { get; set; }

        [Required]
        [ForeignKey("BookingId")]
        public int BookingId { get; set; }
        public virtual Booking BookingID { get; set; }

        [Required]

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer CustomerID { get; set; }

        [Required]
        public string FeedbackMsg { get; set; }

    }
}
