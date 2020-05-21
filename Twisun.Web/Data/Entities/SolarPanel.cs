using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class SolarPanel
    {
        public int Id { get; set; }
        public string Serial { get; set; }

        public Car Car { get; set; }
        public ICollection<DailySolarEnergy> DailySolarEnergies { get; set; }
       
        public DateTime Created_at { get; set; }
        public DateTime Updtaed_at { get; set; }
    }
}
