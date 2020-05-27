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

        
        [MaxLength(200)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Document { get; set; }

        
        [MaxLength(100)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        
        [MaxLength(300)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        
        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(1)]
        public Char? Gender { get; set; }

        public int? Age { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public DateTime Birthday { get; set; }

        [MaxLength(200)]
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        public int UserType { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Car> Cars { get; set; }

        [Display(Name = "Points")]
        public Point Point { get; set; }

        [Display(Name = "Used coupons")]
        public ICollection<UsedCoupon> UsedCoupons { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }

    }
}
