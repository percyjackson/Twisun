using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Document { get; set; }

        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Address { get; set; }

        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }
    }
}
