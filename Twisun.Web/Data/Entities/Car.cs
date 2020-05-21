using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(6)]
        public string Plaque { get; set; }

        [Required]
        [MaxLength(4)]
        public int Model { get; set; }

        [Required]
        [Display(Name = "Total KM")]
        public Decimal TotalKm { get; set; }

        [Required]
        [Display(Name = "Solar KM")]
        public Decimal SolarKm { get; set; }

        [Required]
        [Display(Name = "Charged Batteries")]
        public Decimal ChargedBatteries { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updtaed_at { get; set; }
    }
}
