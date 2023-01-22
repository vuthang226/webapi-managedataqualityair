using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Web.ViewModel2.Common;

namespace Web.Service2.Common
{
    
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);

        Task<SaveFileResult> SaveImageAndHandle(IFormFile imageFile, string fileNameBefore = null);

        public bool CheckExtension(string fileName);

        public bool CheckRegexFilename(string fileName, string stringRegex);
    }
}
