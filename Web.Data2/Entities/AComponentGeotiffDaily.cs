using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class AComponentGeotiffDaily
    {
        public AComponentGeotiffDaily()
        {
            AComponentGeotiffIndexMemPm252021s = new HashSet<AComponentGeotiffIndexMemPm252021>();
            AComponentGeotiffIndexMemPm252022s = new HashSet<AComponentGeotiffIndexMemPm252022>();
            AComponentGeotiffIndexMemPm25nrt2022s = new HashSet<AComponentGeotiffIndexMemPm25nrt2022>();
            AComponentGeotiffIndexWrfPm252021s = new HashSet<AComponentGeotiffIndexWrfPm252021>();
            AComponentGeotiffIndexWrfPm252022s = new HashSet<AComponentGeotiffIndexWrfPm252022>();
            AComponentGeotiffValMemPm252021s = new HashSet<AComponentGeotiffValMemPm252021>();
            AComponentGeotiffValMemPm252022s = new HashSet<AComponentGeotiffValMemPm252022>();
            AComponentGeotiffValMemPm25nrt2022s = new HashSet<AComponentGeotiffValMemPm25nrt2022>();
            AComponentGeotiffValWrfPm252021s = new HashSet<AComponentGeotiffValWrfPm252021>();
            AComponentGeotiffValWrfPm252022s = new HashSet<AComponentGeotiffValWrfPm252022>();
            RAdministrativeAvgs = new HashSet<RAdministrativeAvg>();
        }

        public string GroupcomponentId { get; set; }
        public DateTime? DateShooting { get; set; }
        public string Tablename { get; set; }
        public string Tableindex { get; set; }
        public string Filename { get; set; }
        public double? MinX { get; set; }
        public double? MaxX { get; set; }
        public double? MinY { get; set; }
        public double? MaxY { get; set; }
        public double? ResolutionX { get; set; }
        public double? ResolutionY { get; set; }
        public string Projectioncode { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string CategoryId { get; set; }

        public virtual AGroupComponent Groupcomponent { get; set; }
        public virtual ICollection<AComponentGeotiffIndexMemPm252021> AComponentGeotiffIndexMemPm252021s { get; set; }
        public virtual ICollection<AComponentGeotiffIndexMemPm252022> AComponentGeotiffIndexMemPm252022s { get; set; }
        public virtual ICollection<AComponentGeotiffIndexMemPm25nrt2022> AComponentGeotiffIndexMemPm25nrt2022s { get; set; }
        public virtual ICollection<AComponentGeotiffIndexWrfPm252021> AComponentGeotiffIndexWrfPm252021s { get; set; }
        public virtual ICollection<AComponentGeotiffIndexWrfPm252022> AComponentGeotiffIndexWrfPm252022s { get; set; }
        public virtual ICollection<AComponentGeotiffValMemPm252021> AComponentGeotiffValMemPm252021s { get; set; }
        public virtual ICollection<AComponentGeotiffValMemPm252022> AComponentGeotiffValMemPm252022s { get; set; }
        public virtual ICollection<AComponentGeotiffValMemPm25nrt2022> AComponentGeotiffValMemPm25nrt2022s { get; set; }
        public virtual ICollection<AComponentGeotiffValWrfPm252021> AComponentGeotiffValWrfPm252021s { get; set; }
        public virtual ICollection<AComponentGeotiffValWrfPm252022> AComponentGeotiffValWrfPm252022s { get; set; }
        public virtual ICollection<RAdministrativeAvg> RAdministrativeAvgs { get; set; }
    }
}
