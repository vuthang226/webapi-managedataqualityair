using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class PagcLex
    {
        public int Id { get; set; }
        public int? Seq { get; set; }
        public string Word { get; set; }
        public string Stdword { get; set; }
        public int? Token { get; set; }
        public bool? IsCustom { get; set; }
    }
}
