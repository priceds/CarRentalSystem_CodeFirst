using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="Name Range Exceeded")]
        public string DriverName { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="Driver License Range Exceeded")]
        public string DriverLicensenumber { get; set; }
        [Required]

        [StringLength(100, ErrorMessage = "Email Range Exceeded")]
        public string DriverEmail { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Password Range Exceeded")]
        public string DriverPassword { get; set; }
        [Required]

        [StringLength(10, ErrorMessage = "Phone Digit Range Exceeded")]
        public string DriverPhone { get; set; }
        [Required]

        [StringLength(150, ErrorMessage = "Address Range Exceeded")]
        public string DriverAddress { get; set; }
        [Required]

        [StringLength(5, ErrorMessage = "Addiction Value Range Exceeded")]
        public string AnyAddiction { get; set; }
        [Required]

        [Range(20,50,ErrorMessage ="Driver Age Should Be Between 20 & 50")]
     
        public int? DriverAge { get; set; }
        [Required]
        public string ReviewId { get; set; }
        [Required]
        public string InService { get; set; }
        [Required]
        public string IsActive { get; set; }




    }
}
