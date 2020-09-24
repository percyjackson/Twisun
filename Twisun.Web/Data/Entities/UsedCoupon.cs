
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class UsedCoupon : VersioningCreated
    {
        public int Id { get; set; }

        public Coupon Coupon { get; set; }

        public Owner Owner { get; set; }

    }
}
