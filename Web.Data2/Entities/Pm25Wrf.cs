using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class Pm25Wrf
    {
        public int Fid { get; set; }
        public Polygon Geom { get; set; }
        public string Location { get; set; }
        public DateTime? Ingestion { get; set; }
        public int? Elevation { get; set; }
    }
}
