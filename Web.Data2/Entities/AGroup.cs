using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AGroup
    {
        public AGroup()
        {
            AComponentStationDailies = new HashSet<AComponentStationDaily>();
            AGroupComponents = new HashSet<AGroupComponent>();
            GisAStations = new HashSet<GisAStation>();
            RComponentStationDailyAvgs = new HashSet<RComponentStationDailyAvg>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public bool? Isgroup { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string NameEn { get; set; }
        public string Des { get; set; }
        public string DesEn { get; set; }
        public string Icon { get; set; }
        public bool? Isstation { get; set; }
        public bool? Isaqi { get; set; }
        public bool? Isactive { get; set; }
        public bool? IsstationWeather { get; set; }
        public bool? IslayerModel { get; set; }

        public virtual ICollection<AComponentStationDaily> AComponentStationDailies { get; set; }
        public virtual ICollection<AGroupComponent> AGroupComponents { get; set; }
        public virtual ICollection<GisAStation> GisAStations { get; set; }
        public virtual ICollection<RComponentStationDailyAvg> RComponentStationDailyAvgs { get; set; }
    }
}
