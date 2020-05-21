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

        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must starts with three characters and ends with numbers.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Plaque { get; set; }
        
        [MaxLength(4)]
        public int Model { get; set; }

        [Display(Name = "Total KM")]
        public Decimal TotalKm { get; set; }

        [Display(Name = "Solar KM")]
        public Decimal SolarKm { get; set; }

        [Display(Name = "Charged Batteries")]
        public Decimal ChargedBatteries { get; set; }

        public Owner Owner { get; set; }
        public Battery Battery { get; set; }
        public ICollection<Range> Ranges { get; set; }
        public SolarPanel SolarPanel { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updtaed_at { get; set; }
    }
}
