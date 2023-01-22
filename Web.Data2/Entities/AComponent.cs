using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AComponent
    {
        public AComponent()
        {
            AGroupComponents = new HashSet<AGroupComponent>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Des { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string LegendImg { get; set; }
        public string LegendDes { get; set; }
        public string NameEn { get; set; }
        public string DesEn { get; set; }
        public string LegendDesEn { get; set; }

        public virtual ICollection<AGroupComponent> AGroupComponents { get; set; }
    }
}
