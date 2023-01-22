using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AComponentGeotiffValWrfPm252022
    {
        public int Oid { get; set; }
        public int? RowIndex { get; set; }
        public double? Minx { get; set; }
        public double? Maxx { get; set; }
        public double? Miny { get; set; }
        public double? Maxy { get; set; }
        public string RowVal { get; set; }
        public string CategoryId { get; set; }
        public string RowValAqi { get; set; }

        public virtual AComponentGeotiffDaily Category { get; set; }
    }
}
