using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class LoaderVariable
    {
        public string TigerYear { get; set; }
        public string WebsiteRoot { get; set; }
        public string StagingFold { get; set; }
        public string DataSchema { get; set; }
        public string StagingSchema { get; set; }
    }
}
