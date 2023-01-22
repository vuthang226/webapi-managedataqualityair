using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class CVnaqiIndex
    {
        public int Oid { get; set; }
        public double? AqiFrom { get; set; }
        public double? AqiTo { get; set; }
        public string AqiStatusname { get; set; }
        public string AqiDes { get; set; }
        public string AqiStatusnameEn { get; set; }
        public string AqiDesEn { get; set; }
        public string BgColor { get; set; }
        public string FontColor { get; set; }
        public double? AqiPm25From { get; set; }
        public double? AqiPm25To { get; set; }
    }
}
