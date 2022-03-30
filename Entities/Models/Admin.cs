using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(50,ErrorMessage ="Name Range Exceeded")]
        public string AdminName { get; set; }

        [StringLength(100, ErrorMessage = "Password Range Exceeded")]
        public string AdminPassword { get; set; }

        [StringLength(150, ErrorMessage = "Email Range Exceeded")]
        public string AdminEmail { get; set; }

        [StringLength(10, ErrorMessage = "Phone Number Range Exceeded")]
        public string AdminPhone { get; set; }

        [Required]
        public string IsActive { get; set; }





    }
}
