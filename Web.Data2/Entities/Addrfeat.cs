﻿using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class Addrfeat
    {
        public int Gid { get; set; }
        public long? Tlid { get; set; }
        public string Statefp { get; set; }
        public string Aridl { get; set; }
        public string Aridr { get; set; }
        public string Linearid { get; set; }
        public string Fullname { get; set; }
        public string Lfromhn { get; set; }
        public string Ltohn { get; set; }
        public string Rfromhn { get; set; }
        public string Rtohn { get; set; }
        public string Zipl { get; set; }
        public string Zipr { get; set; }
        public string EdgeMtfcc { get; set; }
        public string Parityl { get; set; }
        public string Parityr { get; set; }
        public string Plus4l { get; set; }
        public string Plus4r { get; set; }
        public string Lfromtyp { get; set; }
        public string Ltotyp { get; set; }
        public string Rfromtyp { get; set; }
        public string Rtotyp { get; set; }
        public string Offsetl { get; set; }
        public string Offsetr { get; set; }
        public Geometry TheGeom { get; set; }
    }
}
