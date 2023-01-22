using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Data2.Entities;
using Web.ViewModel2.Common;

namespace Web.ViewModel2.ManageStation
{
    public class StationModel : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
        public string Des { get; set; }
        public double? CoorX { get; set; }
        public double? CoorY { get; set; }
        public DateTime? Modifydate { get; set; }
        public string Geom { get; set; }
        

        //public StationModel(AGroup group)
        //{
        //    Id = group.Id
        //}
    }
}
