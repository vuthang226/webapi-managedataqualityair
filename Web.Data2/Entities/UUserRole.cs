using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class UUserRole
    {
        public int Oid { get; set; }
        public string Roleid { get; set; }
        public string Userid { get; set; }
        public DateTime? Dateupdate { get; set; }
        public bool? Isroot { get; set; }

        public virtual URole Role { get; set; }
        public virtual UUser User { get; set; }
    }
}
