using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Customer Name Range Exceeded")]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer Password Range Exceeded")]
        public string CustomerPassword { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer Email Range Exceeded")]
        public string CustomerEmail { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer Phone Range Exceeded")]
        public string CustomerPhone { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer Address Range Exceeded")]
        public string CustomerAdress { get; set; }
        [Required]

        [StringLength(50, ErrorMessage = "Customer City Range Exceeded")]
        public string CustomerCity { get; set; }
        [Required]
        public int CustomerPin { get; set; }
        [Required]
        public DateTime? CreatedOn { get; set; }
        [Required]
        public DateTime? UpdatedOn { get; set; }
        [Required]
        public string IsActive { get; set; }

    }
}
