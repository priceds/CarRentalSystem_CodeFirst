﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CarReview
    {
        [Key]
        public int ReviewId { get; set; }
        [ForeignKey("CarId")]
      
        public int CarId { get; set; }
        public virtual Car CarID { get; set; }
    

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer CustomerID {get;set;}
     

        [ForeignKey("BookingId")]
        public int BookingId { get; set; }
        public virtual Booking BookingID { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
