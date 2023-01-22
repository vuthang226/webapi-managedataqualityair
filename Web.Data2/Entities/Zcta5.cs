﻿using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class Zcta5
    {
        public int Gid { get; set; }
        public string Statefp { get; set; }
        public string Zcta5ce { get; set; }
        public string Classfp { get; set; }
        public string Mtfcc { get; set; }
        public string Funcstat { get; set; }
        public double? Aland { get; set; }
        public double? Awater { get; set; }
        public string Intptlat { get; set; }
        public string Intptlon { get; set; }
        public string Partflg { get; set; }
        public Geometry TheGeom { get; set; }
    }
}
