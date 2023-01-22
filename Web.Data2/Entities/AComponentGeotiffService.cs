using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AComponentGeotiffService
    {
        public string GroupcomponentId { get; set; }
        public string Urlservice { get; set; }
        public string Featuretype { get; set; }
        public string Featurebase { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public bool? Timeslider { get; set; }
        public string Typeslider { get; set; }
        public bool? Visible { get; set; }
        public string Type { get; set; }
        public int? Orderservice { get; set; }
        public int Oid { get; set; }

        public virtual AGroupComponent Groupcomponent { get; set; }
    }
}
