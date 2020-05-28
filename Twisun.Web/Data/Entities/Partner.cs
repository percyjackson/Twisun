﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Partner
    {
        public int Id { get; set; }

        public User User { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }  

        public int? Points { get; set; }

        public ICollection<Coupon> Coupons { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }

    }
}