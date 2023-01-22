using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class VAComponentStationDailyGropuidLatest7Day
    {
        public string GroupId { get; set; }
        public double? AqiPm25 { get; set; }
        public DateTime? DatetimeShooting { get; set; }
    }
}
