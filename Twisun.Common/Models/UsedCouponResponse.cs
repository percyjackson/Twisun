using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class UsedCouponResponse
    {
        public int Id { get; set; }
        public CouponResponse Coupon { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
