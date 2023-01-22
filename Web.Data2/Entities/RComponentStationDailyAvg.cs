using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class RComponentStationDailyAvg
    {
        public int Oid { get; set; }
        public string GroupId { get; set; }
        public DateTime? DateShooting { get; set; }
        public double? Pm25 { get; set; }
        public double? AqiPm25 { get; set; }
        public double? Pm10 { get; set; }
        public double? AqiPm10 { get; set; }
        public double? No2 { get; set; }
        public double? AqiNo2 { get; set; }
        public double? Co { get; set; }
        public double? AqiCo { get; set; }
        public double? So2 { get; set; }
        public double? AqiSo2 { get; set; }
        public double? O3 { get; set; }
        public double? AqiO3 { get; set; }
        public double? Altm { get; set; }
        public double? Temp { get; set; }
        public double? Hud { get; set; }
        public double? Wdir { get; set; }
        public double? Wspd { get; set; }
        public double? Vis { get; set; }
        public double? Aqi { get; set; }

        public virtual AGroup Group { get; set; }
    }
}
