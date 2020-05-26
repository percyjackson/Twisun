using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class SolarPanel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Serial { get; set; }

        public Car Car { get; set; }
        public int CarId { get; set; }
        public ICollection<DailySolarEnergy> DailySolarEnergies { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updtaed_at { get; set; }
    }
}
