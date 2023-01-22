using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class StateLookup
    {
        public int StCode { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public string Statefp { get; set; }
    }
}
