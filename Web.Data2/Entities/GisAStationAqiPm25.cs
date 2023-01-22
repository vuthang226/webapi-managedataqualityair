using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class GisAStationAqiPm25
    {
        public int? Gid { get; set; }
        public string GroupId { get; set; }
        public string ParentId { get; set; }
        public double? CoorX { get; set; }
        public double? CoorY { get; set; }
        public Point Geom { get; set; }
        public double? AqiPm25 { get; set; }
    }
}
