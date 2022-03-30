using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string CarRtoNumber { get; set; }
        public string CarType { get; set; }
        public decimal? CarMileage { get; set; }
        public int? CarPersonCapacity { get; set; }
        public string CarCondition { get; set; }
        public decimal? KmDone { get; set; }
        public string FuelType { get; set; }
        public decimal? RentPerKm { get; set; }
        public string ReviewId { get; set; }
        public string InService { get; set; }

    }
}
