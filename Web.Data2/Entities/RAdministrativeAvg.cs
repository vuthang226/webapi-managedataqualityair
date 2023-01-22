using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class RAdministrativeAvg
    {
        public int Oid { get; set; }
        public string DistrictId { get; set; }
        public double? ValSum { get; set; }
        public int? Num { get; set; }
        public double? ValAvg { get; set; }
        public string CategoryId { get; set; }
        public int? ValSumAqi { get; set; }
        public int? ValAvgAqi { get; set; }

        public virtual AComponentGeotiffDaily Category { get; set; }
        public virtual GisAdministrativeDistrict District { get; set; }
    }
}
