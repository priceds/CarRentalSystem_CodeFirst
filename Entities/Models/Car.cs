using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Model Range Exceeded")]
        public string CarModel { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Rto Number Range Exceeded")]
        public string CarRtoNumber { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Car Type Range Exceeded")]
        public string CarType { get; set; }

        [Required]
      
        [Range(5,28,ErrorMessage ="Car's Mileage Should Be Between 5kmpl-28kmpl")]
        public int? CarMileage { get; set; }

        [Required]
        public int? CarPersonCapacity { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Car Condition Range Exceeded")]
        public string CarCondition { get; set; }

        [Required]
        public int? KmDone { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Fuel Type Range Exceeded")]
        public string FuelType { get; set; }

        [Required]
        
        public int? RentPerKm { get; set; }

        [Required]
        [ForeignKey("ReviewId")]
        public string ReviewId { get; set; }
        public virtual CarReview ReviewID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "In Service Range Exceeded")]
        public string InService { get; set; }

    }
}
