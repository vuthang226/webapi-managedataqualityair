using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class ZipLookupBase
    {
        public string Zip { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Statefp { get; set; }
    }
}
