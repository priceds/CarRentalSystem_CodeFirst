using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DriverReview
    {
        public int ReviewId { get; set; }
        [ForeignKey("DriverId")]

        [Required]
        public int DriverId { get; set; }
        public virtual Driver DriverID { get; set; }

        [Required]

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer CustomerID { get; set; }

        [Required]

        [ForeignKey("CarId")]

        public int CarId { get; set; }
        public virtual Car CarID { get; set; }
        [Required]
        public int BookingId { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}
