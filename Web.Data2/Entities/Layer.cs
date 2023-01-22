using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class Layer
    {
        public int TopologyId { get; set; }
        public int LayerId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string FeatureColumn { get; set; }
        public int FeatureType { get; set; }
        public int Level { get; set; }
        public int? ChildId { get; set; }

        public virtual Topology Topology { get; set; }
    }
}
