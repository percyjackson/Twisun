using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class OwnerResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Char Gender { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int TotalPoints { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Document { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PicturePath { get; set; }
        public ICollection<CarResponse> Cars { get; set; }
        public ICollection<UsedCouponResponse> UsedCoupons { get; set; }
    }
}
