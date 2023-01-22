using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class ADlfileentry
    {
        public ADlfileentry()
        {
            ADlfileversions = new HashSet<ADlfileversion>();
        }

        public int Oid { get; set; }
        public string Fileentryid { get; set; }
        public string Repositoryid { get; set; }
        public string Folderid { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Mimetype { get; set; }
        public string Title { get; set; }
        public double? Size { get; set; }
        public string Treepath { get; set; }
        public string Version { get; set; }
        public string Classname { get; set; }
        public string Classpk { get; set; }
        public string Host { get; set; }
        public string Userid { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }

        public virtual ADlfolder Folder { get; set; }
        public virtual ICollection<ADlfileversion> ADlfileversions { get; set; }
    }
}
