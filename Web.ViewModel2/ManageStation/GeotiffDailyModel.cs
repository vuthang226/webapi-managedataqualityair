using System;
using System.Collections.Generic;
using System.Text;
using Web.ViewModel2.Common;

namespace Web.ViewModel2.ManageStation
{
    public class GeotiffDailyModel:PagingRequestBase
    {
        public string GroupcomponentId { get; set; }
        public DateTime? DateShooting { get; set; }
        public string Keyword { get; set; }
        public string Tablename { get; set; }
        public string Groupcomponentname { get; set; }
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
    }
}
