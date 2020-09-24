using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class DailySolarEnergy
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float Value  { get; set; }

        public SolarPanel SolarPanel { get; set; }
        

    }
}
