using System;
using System.Collections.Generic;
using System.Text;

namespace Web.ViewModel2.Common
{
    public class SaveFileResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }    
        public DateTime Time { get; set; }
        public string path { get; set; }
    
        public SaveFileResult()
        {
            this.Success = true;
        }
        public void OnSuccess(string fileName, DateTime Time, string path)
        {
            this.FileName = fileName;
            this.Success = true;
            this.Time = Time;
            this.path = path;
   
        }
        public void OnError(string mess)
        {
            this.Success = false;
            this.Message = mess;
        }
    }
}
