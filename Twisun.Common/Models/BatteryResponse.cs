using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class BatteryResponse
    {
        public int Id { get; set; }
        public float Capacity { get; set; }
        public float StateOfCharge { get; set; }
        public float SolarLevel { get; set; }
        public float OutletLevel { get; set; }
        public float StateOfHealth { get; set; }
    }
}
