﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Manager
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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }
    }
}