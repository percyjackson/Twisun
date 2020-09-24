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
        [ForeignKey("Car")]
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

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateLocal => Date.ToLocalTime();

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
