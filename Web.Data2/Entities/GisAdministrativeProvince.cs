using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class GisAdministrativeProvince
    {
        public GisAdministrativeProvince()
        {
            CfPinnedLocations = new HashSet<CfPinnedLocation>();
            GisAdministrativeCommunnes = new HashSet<GisAdministrativeCommunne>();
            GisAdministrativeDistricts = new HashSet<GisAdministrativeDistrict>();
        }

        public int Gid { get; set; }
        public MultiPolygon Geom { get; set; }
        public string ProvinceId { get; set; }
        public string NameVi { get; set; }
        public double? ExtentMinx { get; set; }
        public double? ExtentMaxx { get; set; }
        public double? ExtentMiny { get; set; }
        public double? ExtentMaxy { get; set; }
        public string NameEn { get; set; }
        public string TypeVi { get; set; }
        public string TypeEn { get; set; }

        public virtual ICollection<CfPinnedLocation> CfPinnedLocations { get; set; }
        public virtual ICollection<GisAdministrativeCommunne> GisAdministrativeCommunnes { get; set; }
        public virtual ICollection<GisAdministrativeDistrict> GisAdministrativeDistricts { get; set; }
    }
}
