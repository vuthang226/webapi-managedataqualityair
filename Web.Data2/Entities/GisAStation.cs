using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class GisAStation
    {
        public int Gid { get; set; }
        public string GroupId { get; set; }
        public double? CoorX { get; set; }
        public double? CoorY { get; set; }
        public Point Geom { get; set; }

        public virtual AGroup Group { get; set; }
    }
}
