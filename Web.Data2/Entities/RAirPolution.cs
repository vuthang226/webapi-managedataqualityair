using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class RAirPolution
    {
        public int Oid { get; set; }
        public string FileentryId { get; set; }
        public string FileentryThumbnailId { get; set; }
        public string Reportname { get; set; }
        public string Reportdate { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
    }
}
