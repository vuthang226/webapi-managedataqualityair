using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class CfPinnedLocation
    {
        public int Oid { get; set; }
        public string ProvinceId { get; set; }
        public string UserId { get; set; }

        public virtual GisAdministrativeProvince Province { get; set; }
    }
}
