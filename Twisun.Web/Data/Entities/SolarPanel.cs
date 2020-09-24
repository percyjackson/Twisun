using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Twisun.Web.Data.Entities
{
    public class SolarPanel : Versioning
    {
        [ForeignKey("Car")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Serial { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Number Of Cells")]
        public int Cells { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Folded Area")]
        public float FoldedArea { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Unfolded Area")]
        public float UnfoldedArea { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Estimated Efficiency")]
        public float EstimatedEfficiency { get; set; }

        public Car Car { get; set; }
        public ICollection<DailySolarEnergy> DailySolarEnergies { get; set; }

    }
}
