using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("CarId")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public virtual Driver driver { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int NoOfPersons { get; set; }
        public string BookingStatus { get; set; }
        public string JourneyCompletion { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
