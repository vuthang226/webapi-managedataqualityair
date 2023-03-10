using System;
using System.Collections.Generic;
using System.Text;
using Web.ViewModel2.Common;

namespace Web.ViewModel2.ManageStation.StationDaily
{
    public class StationDailyModel : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int? Oid { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime? DatetimeShooting { get; set; }
        public int? DatetimeType { get; set; }

        public string DataShooting { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        //public NpgsqlTsVector SearchTsv { get; set; }
        public double? Pm25 { get; set; }
        public double? AqiPm25 { get; set; }
        public double? Pm10 { get; set; }
        public double? AqiPm10 { get; set; }
        public double? No2 { get; set; }
        public double? AqiNo2 { get; set; }
        public double? Co { get; set; }
        public double? AqiCo { get; set; }
        public double? So2 { get; set; }
        public double? AqiSo2 { get; set; }
        public double? O3 { get; set; }
        public double? AqiO3 { get; set; }
        public double? Altm { get; set; }
        public double? Temp { get; set; }
        public double? Hud { get; set; }
        public double? Wdir { get; set; }
        public double? Wspd { get; set; }
        public double? Vis { get; set; }
        public double? Aqi { get; set; }
    }
}
