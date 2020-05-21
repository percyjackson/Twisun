using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Battery
    {
        public int Id { get; set; }

        public float Capacity { get; set; }
        public float StateOfCharge { get; set; }
        public float SolarLevel { get; set; }
        public float OutletLevel { get; set; }
        public float StateOfHealth { get; set; }

        public Car Car { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updtaed_at { get; set; }
    }
}
