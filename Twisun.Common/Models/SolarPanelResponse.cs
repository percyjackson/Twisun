using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class SolarPanelResponse
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public int Cells { get; set; }
        public float FoldedArea { get; set; }
        public float UnfoldedArea { get; set; }
        public float EstimatedEfficiency { get; set; }
        public ICollection<DailySolarEnergyResponse> DailySolarEnergies { get; set; }
    }
}
