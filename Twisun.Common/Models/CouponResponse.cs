using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class CouponResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public string Partner { get; set; }
    }
}
