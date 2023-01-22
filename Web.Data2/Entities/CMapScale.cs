using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class CMapScale
    {
        public int Oid { get; set; }
        public double? ScaleVal { get; set; }
        public string ScaleAlias { get; set; }
    }
}
