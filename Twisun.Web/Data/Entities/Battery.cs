using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Battery
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The field {0} is mandatory.")]
        public float Capacity { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float StateOfCharge { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float SolarLevel { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float OutletLevel { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public float StateOfHealth { get; set; }

        public Car Car { get; set; }
        public int CarId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_at { get; set; }
    }
}
