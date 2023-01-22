using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class VAdministrativeProvinceAvg
    {
        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceNameEn { get; set; }
        public string CategoryId { get; set; }
        public DateTime? DateShooting { get; set; }
        public double? Avg { get; set; }
        public decimal? AvgAqi { get; set; }
    }
}
