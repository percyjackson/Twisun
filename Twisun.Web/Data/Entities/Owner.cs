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

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(300)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(1)]
        public Char Gender { get; set; }

        public int Age { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [MaxLength(200)]
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        public string UserType { get; set; }

        //public string FullName 
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Car> Cars { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }

    }
}
