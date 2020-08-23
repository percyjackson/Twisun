
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class UsedCoupon
    {
        public int Id { get; set; }

        public Coupon Coupon { get; set; }
        public int CouponId { get; set; }

        public Owner Owner { get; set; }
        public int OwnerId { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public DateTime Created_at { get; set; }
    }
}
