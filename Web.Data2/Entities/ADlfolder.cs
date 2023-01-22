using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class ADlfolder
    {
        public ADlfolder()
        {
            ADlfileentries = new HashSet<ADlfileentry>();
            ADlfileversions = new HashSet<ADlfileversion>();
        }

        public int Oid { get; set; }
        public string Folderid { get; set; }
        public string Parentfolderid { get; set; }
        public string Treepath { get; set; }
        public string Repositoryid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Userid { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }

        public virtual ICollection<ADlfileentry> ADlfileentries { get; set; }
        public virtual ICollection<ADlfileversion> ADlfileversions { get; set; }
    }
}
