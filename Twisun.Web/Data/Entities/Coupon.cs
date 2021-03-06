﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Coupon : Versioning
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Status { get; set; }

        public Partner Partner { get; set; }

        [Display(Name = "Claimed coupons")]
        public ICollection<UsedCoupon> UsedCoupons { get; set; }

    }
}
