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


        [Required]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        [ForeignKey("CarId")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public virtual Driver driver { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
        [Required]
        public string FromLocation { get; set; }
        [Required]
        public string ToLocation { get; set; }
        [Required]

        [Range(1,5,ErrorMessage ="Max 5 And Min 1 People Allowed")]
        public int NoOfPersons { get; set; }
        [Required]

        [StringLength(50,ErrorMessage ="Status Range Exceeded")]
        public string BookingStatus { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Journey Completion Range Exceded")]
        public string JourneyCompletion { get; set; }
        [Required]

        [StringLength(50, ErrorMessage = "Payment Status Range Exceded")]
        public string PaymentStatus { get; set; }
        [Required]
        public DateTime? CreatedOn { get; set; }
        [Required]
        public DateTime? UpdatedOn { get; set; }

    }
}
