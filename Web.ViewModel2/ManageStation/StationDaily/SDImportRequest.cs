using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.ViewModel2.ManageStation.StationDaily
{
    public class SDImportRequest
    {
        public IFormFile CsvFile { get; set; }
        public string GroupId { get; set; }
    }
}
