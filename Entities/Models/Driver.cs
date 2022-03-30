using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string DriverLicensenumber { get; set; }
        public string DriverEmail { get; set; }
        public string DriverPassword { get; set; }
        public string DriverPhone { get; set; }
        public string DriverAddress { get; set; }
        public string AnyAddiction { get; set; }
        public int? DriverAge { get; set; }
        public string ReviewId { get; set; }
        public string InService { get; set; }
        public string IsActive { get; set; }




    }
}
