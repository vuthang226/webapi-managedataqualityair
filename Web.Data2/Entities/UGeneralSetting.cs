using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Data2.Entities
{
    public partial class UGeneralSetting
    {
        public int Oid { get; set; }
        public string Themeid { get; set; }
        public string Languagedefaultid { get; set; }
        public string Formatdate { get; set; }
        public string Formattime { get; set; }
        public string Symbolcurrency { get; set; }
        public string SymbolcurrencyDigitgroup { get; set; }
        public string SymbolcurrencyDigitdecimal { get; set; }
        public short? NumbercurrencyDigitdecimal { get; set; }
        public string SymbolnumberDigitgroup { get; set; }
        public string SymbolnumberDigitdecimal { get; set; }
        public short? NumberDigitdecimal { get; set; }
        public string Projection { get; set; }
        public string UnitScale { get; set; }
        public double? ExtentMapX1 { get; set; }
        public double? ExtentMapX2 { get; set; }
        public double? ExtentMapY1 { get; set; }
        public double? ExtentMapY2 { get; set; }
        public long? MaxSizeFile { get; set; }
        public string EmailServerPop { get; set; }
        public int? EmailGate { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
        public bool? Ssl { get; set; }
        public bool? UseLdap { get; set; }
        public bool? DomainLdap { get; set; }
        public bool? EmailPasswordencrypted { get; set; }
    }
}
