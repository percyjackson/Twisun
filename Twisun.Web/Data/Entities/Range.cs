using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Range
    {
        public int Id { get; set; }
        public float Value { get; set; }

        public Car Car { get; set; }

        public DateTime Created_at { get; set; }
    }
}
