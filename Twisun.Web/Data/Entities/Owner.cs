using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [MaxLength(300, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(1, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public Char? Gender { get; set; }

        public int? Age { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public DateTime Birthday { get; set; }

        public int? TotalPoints { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Car> Cars { get; set; }

        public ICollection<Point> Points { get; set; }


        [Display(Name = "Used coupons")]
        public ICollection<UsedCoupon> UsedCoupons { get; set; }


    }
}
