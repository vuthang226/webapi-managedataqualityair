using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AGroupComponent
    {
        public AGroupComponent()
        {
            AComponentGeotiffDailies = new HashSet<AComponentGeotiffDaily>();
            AComponentGeotiffServices = new HashSet<AComponentGeotiffService>();
        }

        public string GroupId { get; set; }
        public string ComponentId { get; set; }
        public bool? Isshow { get; set; }
        public bool? Isactive { get; set; }
        public int? Ordercomponent { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string Id { get; set; }

        public virtual AComponent Component { get; set; }
        public virtual AGroup Group { get; set; }
        public virtual ICollection<AComponentGeotiffDaily> AComponentGeotiffDailies { get; set; }
        public virtual ICollection<AComponentGeotiffService> AComponentGeotiffServices { get; set; }
    }
}
