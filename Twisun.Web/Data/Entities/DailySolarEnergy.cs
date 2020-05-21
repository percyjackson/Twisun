using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class DailySolarEnergy
    {
        public int Id { get; set; }
        public float Value  { get; set; }

        public SolarPanel SolarPanel { get; set; }
        public DateTime Created_at { get; set; }
    }
}
