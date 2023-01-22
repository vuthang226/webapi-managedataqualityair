using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class VAdministrativeProvince
    {
        public int? Gid { get; set; }
        public string ProvinceId { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Type { get; set; }
        public string TypeEn { get; set; }
    }
}
