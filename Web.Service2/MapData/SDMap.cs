using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Web.Data2.Entities;

namespace Web.Service2.MapData
{
    public class SDMap : ClassMap<AComponentStationDaily>
    {
        public SDMap()
        {
            string format = "dd/MM/yyyy HH:mm";
            var msMY = CultureInfo.GetCultureInfo("ms-MY");

            Map(m => m.Altm).Name("barometer", "press");
            Map(m => m.Aqi).Name("AQI");
            Map(m => m.AqiCo).Name("AQICO");
            Map(m => m.AqiNo2).Name("AQINO2");
            Map(m => m.AqiO3).Name("AQIO3");
            Map(m => m.AqiPm10).Name("AQIPM10");
            Map(m => m.AqiPm25).Name("AQINO2");
            Map(m => m.AqiSo2).Name("AQISO2");
            Map(m => m.Co).Name("CO");
            Map(m => m.Hud).Name("rh");
            Map(m => m.DatetimeShooting).Name("aqstime").TypeConverterOption.Format(format)
              .TypeConverterOption.CultureInfo(msMY);
            Map(m => m.No2).Name("NO2");
            Map(m => m.O3).Name("O3");
            Map(m => m.Pm10).Name("PM10");
            Map(m => m.Pm25).Name("PM25");
            Map(m => m.So2).Name("SO2");
            Map(m => m.Temp).Name("temp");
            Map(m => m.Vis).Name("vis");
            Map(m => m.Wdir).Name("windir");
            Map(m => m.Wspd).Name("winspd");
       
        }
        
    }
}
