using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Web.ViewModel2.Common;

namespace Web.Service2.Common
{
    public class FileStorageService:IStorageService
    {
        private readonly string _userContentFolder;
        private const string USER_CONTENT_FOLDER_NAME = "manage/public/image";

        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            _userContentFolder = Path.Combine(webHostEnvironment.ContentRootPath, USER_CONTENT_FOLDER_NAME);
        }

        public string GetFileUrl(string fileName)
        {
            return $"{_userContentFolder}/{fileName}";
        }

        public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
        }

        public async Task DeleteFileAsync(string fileName)
        {
            string[] words = Path.GetFileNameWithoutExtension(fileName).Split('_');
            var filePath = Path.Combine(_userContentFolder, words[0], words[1].Substring(0, 4), words[1].Substring(4, 2), fileName);
       
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }

        /// <summary>
        /// Hop le tra ve true ko hop le false
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool CheckExtension(string fileName)
        {
            if (Path.GetExtension(fileName) != ".tiff" && Path.GetExtension(fileName) != ".tif")
            {
                return false;
            }return true;
        }

        /// <summary>
        /// Check file name
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool CheckRegexFilename(string fileName,string stringRegex)
        {
            if (!CheckExtension(fileName)) return false;
            string name = Path.GetFileNameWithoutExtension(fileName);
            Regex regex = new Regex(stringRegex);
            Match match = regex.Match(name);
            if (!match.Success)       
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Luu anh (neu co fileNameBefore thi update anh da co)
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="fileNameBefore"></param>
        /// <returns></returns>
        public async Task<SaveFileResult> SaveImageAndHandle(IFormFile imageFile, string fileNameBefore = null)
        {
            //check filename
            string[] words;
            string fileName = imageFile.FileName;
            DateTime timeShooting;
            SaveFileResult result = new SaveFileResult();
            //Check handel is add or update
            if (fileNameBefore != null)
            {
                fileName = fileNameBefore;     
            }
            
            words = Path.GetFileNameWithoutExtension(fileName).Split('_');
            try
            {
                timeShooting = DateTime.Parse(words[1].Substring(0, 4) + '-' + words[1].Substring(4, 2) + '-' + words[1].Substring(6, 2));
            }
            catch (Exception e)
            {
                result.OnError($"{fileName}");
                return result;
            }
            //Get all image path
            var imagePath = Path.Combine(_userContentFolder, words[0], words[1].Substring(0, 4), words[1].Substring(4, 2), fileName);
            //Check file is exists => Create
            if (!File.Exists(imagePath))
            {
                var folder = Path.Combine(_userContentFolder, words[0], words[1].Substring(0, 4), words[1].Substring(4, 2));
                //Make new folder
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                }
            }
            else
            {
                if (fileNameBefore == null)
                {
                    result.OnError($"{fileName}");
                    return result;
                }
                else
                {
                    await Task.Run(() => File.Delete(imagePath));
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }
                }
                
            }
            
            result.OnSuccess(fileName, timeShooting, Path.Combine(_userContentFolder , words[0], words[1].Substring(0, 4), words[1].Substring(4, 2)));
            return result;

        }


    }
}
