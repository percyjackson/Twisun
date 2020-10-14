using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class DailySolarEnergyResponse
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
