using System;
using System.Collections.Generic;
using System.Text;

namespace Twisun.Common.Models
{
    public class CarResponse
    {
        public int Id { get; set; }
        public string Plaque { get; set; }
        public int Model { get; set; }
        public float TotalKm { get; set; }
        public float SolarKm { get; set; }
        public float ChargedBatteries { get; set; }
        public BatteryResponse Battery { get; set; }
        public ICollection<RangeResponse> Ranges { get; set; }
        public SolarPanelResponse SolarPanel { get; set; }
    }
}
