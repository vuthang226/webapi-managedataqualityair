using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AComponentGeotiffIndexWrfPm252021
    {
        public int Oid { get; set; }
        public int? RowIndex { get; set; }
        public string CategoryId { get; set; }
        public int? FromCell { get; set; }
        public int? ToCell { get; set; }

        public virtual AComponentGeotiffDaily Category { get; set; }
    }
}
