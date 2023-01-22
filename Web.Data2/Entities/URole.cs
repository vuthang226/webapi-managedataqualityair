using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class URole
    {
        public URole()
        {
            UUserRoles = new HashSet<UUserRole>();
        }

        public int Oid { get; set; }
        public string Roleid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Userid { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public bool? Rolesystem { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<UUserRole> UUserRoles { get; set; }
    }
}
