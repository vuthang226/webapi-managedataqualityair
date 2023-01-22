using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class GisAdministrativeDistrict
    {
        public GisAdministrativeDistrict()
        {
            GisAdministrativeCommunnes = new HashSet<GisAdministrativeCommunne>();
            RAdministrativeAvgs = new HashSet<RAdministrativeAvg>();
        }

        public int Gid { get; set; }
        public MultiPolygon Geom { get; set; }
        public string DistrictId { get; set; }
        public string NameVi { get; set; }
        public string ProvinceId { get; set; }
        public double? ExtentMinx { get; set; }
        public double? ExtentMaxx { get; set; }
        public double? ExtentMiny { get; set; }
        public double? ExtentMaxy { get; set; }
        public string NameEn { get; set; }
        public string TypeVi { get; set; }
        public string TypeEn { get; set; }

        public virtual GisAdministrativeProvince Province { get; set; }
        public virtual ICollection<GisAdministrativeCommunne> GisAdministrativeCommunnes { get; set; }
        public virtual ICollection<RAdministrativeAvg> RAdministrativeAvgs { get; set; }
    }
}
