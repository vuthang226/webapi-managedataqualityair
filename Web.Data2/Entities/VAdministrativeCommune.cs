using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class VAdministrativeCommune
    {
        public int? Gid { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string CommuneId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Type { get; set; }
        public string TypeEn { get; set; }
    }
}
