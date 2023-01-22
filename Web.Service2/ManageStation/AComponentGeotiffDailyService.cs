using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.EF;
using Web.Service2.Data;
using Web.Data2.Entities;
using Web.Service2.Common;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;
using System.IO;
using OSGeo.GDAL;

namespace Web.Service2.ManageStation
{
    public class AComponentGeotiffDailyService : IAComponentGeotiffDailyService
    {
        private readonly apom_app_svContext _context;
        private readonly IdataContext _datacontext;
        private readonly IStorageService _storageService;
        public AComponentGeotiffDailyService(apom_app_svContext context,IdataContext datacontext, IStorageService storageService)
        {
            _context = context;
            _datacontext = datacontext;
            _storageService = storageService;
         
        }

        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AComponentGeotiffDailies.FirstOrDefaultAsync(x => x.CategoryId == id);
            serviceResult.OnSuccess(item);
            return serviceResult;
        }

        /// <summary>
        /// Tạo dữ liệu ảnh
        /// </summary>
        /// <param name="formImage">Dữ liệu ảnh ngày</param>
        /// <returns></returns>
        public async Task<ServiceResult> Create(List<IFormFile> formImage)
        {
            ServiceResult serviceResult = new ServiceResult();
            List<string> imgFail = new List<string>();
            GdalConfiguration.ConfigureGdal();
            Gdal.AllRegister();
            int num = 0;
            if (formImage != null)
            {
            
                SaveFileResult result = new SaveFileResult();
                foreach (IFormFile image in formImage)
                {
                    if (!_storageService.CheckRegexFilename(image.FileName, @"PM25_[0-9]{8}_3km\w*"))
                    {
                        imgFail.Add(image.FileName);
                        continue;
                    }
                    string categoryId;
                    string[] words = Path.GetFileNameWithoutExtension(image.FileName).Split('_');

                    if (image.FileName.ToLower().Contains("nrt"))
                    {
                        categoryId = $"mem_pm25_nrt_{words[1].Substring(0, 4)}_{words[1].Substring(4, 2)}_{words[1].Substring(6, 2)}";
                    }
                    else
                    {
                        categoryId = $"mem_pm25_{words[1].Substring(0, 4)}_{words[1].Substring(4, 2)}_{words[1].Substring(6, 2)}";
                    }
                    if (_context.AComponentGeotiffDailies.Any(x => x.CategoryId == categoryId))
                    {
                        imgFail.Add(image.FileName);
                        continue;
                    }
                    result = await _storageService.SaveImageAndHandle(image);
                    if (!result.Success)
                    {
                        imgFail.Add(image.FileName);
                        continue;
                    }
                    int ind = await _datacontext.CreateTableGeotiffIndex(result.Time.Year);
                    int val = await _datacontext.CreateTableGeotiffVal(result.Time.Year);
                    
                    var dataset = Gdal.Open(Path.Combine(result.path, result.FileName), Access.GA_ReadOnly);
                    Band data = dataset.GetRasterBand(1);
                    double[] geos = new double[6];
                    dataset.GetGeoTransform(geos);
                    int cols = dataset.RasterXSize;
                    int rows = dataset.RasterYSize;
                    double[] rasterValues = new double[cols * rows];
                    data.ReadRaster(0, 0, cols, rows, rasterValues, cols, rows, 0, 0);

                    await _context.AComponentGeotiffDailies.AddAsync(new AComponentGeotiffDaily
                    {
                        CategoryId = categoryId,
                        GroupcomponentId = "63",
                        DateShooting = result.Time,
                        Tablename = $"a_component_geotiff_val_mem_pm25_{result.Time.Year}",
                        Tableindex = $"a_component_geotiff_index_mem_pm25_{result.Time.Year}",

                        MinX = geos[0],
                        MaxX = geos[0] + cols * geos[1],
                        MinY = geos[3] + rows * geos[5],
                        MaxY = geos[3],
                        ResolutionX = geos[1],
                        ResolutionY = geos[5],
                        Projectioncode = "EPSG:4326",
                        Createdate = DateTime.Now,

                        Modifydate = DateTime.Now,

                        Filename = result.FileName,

                    }); 
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        num++;
                        for (int i = 0; i < rows; i++)
                        {
                            int j = 0;
                            List<double> rows_val = new List<double>();
                     
                            while (j < cols)
                            {
                                if (rasterValues[i * cols + j] != -9999)
                                {
                                    rows_val.Add(rasterValues[i * cols + j]);
                                    int firstIndex = j;
                                    int lastIndex = j;
                                    j = j + 1;
                                    while (j < cols)
                                    {
                                        if (rasterValues[i * cols + j] != -9999)
                                        {
                                            rows_val.Add(rasterValues[i * cols + j]);
                                            j = j + 1;
                                        }
                                        else break;
                                    }
                                    lastIndex = j - 1;
                                    int insertIndex = await _datacontext.InsertGeotiffIndex(result.Time.Year, i, categoryId, firstIndex, lastIndex);
                                }
                                else j = j + 1;

                            }
                            if (rows_val.Count > 0)
                            {
                                string rows_val_aqi_str = string.Empty;
                                string rows_val_str = string.Empty;

                                foreach (double item in rows_val)
                                {
                                    rows_val_str+=item.ToString("N2").Replace(',','.') +',';
                                    rows_val_aqi_str += dailyPM2AQI(item).ToString("N2").Replace(',', '.') + ',';
                                }
                                rows_val_str = rows_val_str.Remove(rows_val_str.Length - 1);
                                rows_val_aqi_str = rows_val_aqi_str.Remove(rows_val_str.Length - 1);



                                int insertVal = await _datacontext.InsertGeotiffVal(result.Time.Year, i, geos[0], (geos[0] + cols * geos[1]), (geos[3] + (i + 1) * geos[5]), (geos[3] + (i) * geos[5]), rows_val_str, categoryId, rows_val_aqi_str);


                            }


                        }

                    }


                }
                await _context.SaveChangesAsync();
                string mess = "";
                if (num > 0)
                {
                    mess += $"Thành công tạo {num} ảnh.";
                }
                if (imgFail.Count > 0)
                {
                    mess += string.Join(", ", imgFail);
                    mess += " lưu không thành công";
                }
                serviceResult.OnSuccess(num, mess);

            }
            return serviceResult;
        }


        public async Task<ServiceResult> Update(string id, IFormFile image)
        {
            ServiceResult serviceResult = new ServiceResult();
            GdalConfiguration.ConfigureGdal();
            Gdal.AllRegister();
            if (image != null)
            {

                SaveFileResult result = new SaveFileResult();

                if (!_storageService.CheckExtension(image.FileName))
                {
                    serviceResult.OnError(0, "Ảnh không hợp lệ");
                    return serviceResult;

                }
                var item = await _context.AComponentGeotiffDailies.FirstOrDefaultAsync(x => x.CategoryId == id);
                if (item == null)
                {
                    serviceResult.OnError(0, "Ảnh không tồn tại");
                    return serviceResult;
                }
                result = await _storageService.SaveImageAndHandle(image,item.Filename);
                if (!result.Success)
                {
                    serviceResult.OnError(0, "Lưu ảnh không thành công");
                    return serviceResult;
                }
                //int ind = await _datacontext.CreateTableGeotiffIndex(result.Time.Year);
                //int val = await _datacontext.CreateTableGeotiffVal(result.Time.Year);

                var dataset = Gdal.Open(Path.Combine(result.path, result.FileName), Access.GA_ReadOnly);
                Band data = dataset.GetRasterBand(1);
                double[] geos = new double[6];
                dataset.GetGeoTransform(geos);
                int cols = dataset.RasterXSize;
                int rows = dataset.RasterYSize;
                double[] rasterValues = new double[cols * rows];
                data.ReadRaster(0, 0, cols, rows, rasterValues, cols, rows, 0, 0);

                item.MinX = geos[0];
                item.MaxX = geos[0] + cols * geos[1];
                item.MinY = geos[3] + rows * geos[5];
                item.MaxY = geos[3];
                item.ResolutionX = geos[1];
                item.ResolutionY = geos[5];
                item.Modifydate = DateTime.Now;
                if (await _context.SaveChangesAsync() > 0)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        int j = 0;
                        List<double> rows_val = new List<double>();
             
                        while (j < cols)
                        {
                            if (rasterValues[i * cols + j] != -9999)
                            {
                                rows_val.Add(rasterValues[i * cols + j]);
                                int firstIndex = j;
                                int lastIndex = j;
                                j = j + 1;
                                while (j < cols)
                                {
                                    if (rasterValues[i * cols + j] != -9999)
                                    {
                                        rows_val.Add(rasterValues[i * cols + j]);
                                        j = j + 1;
                                    }
                                    else break;
                                }
                                lastIndex = j - 1;
                                int insertIndex = await _datacontext.InsertGeotiffIndex(result.Time.Year, i, item.CategoryId, firstIndex, lastIndex);
                            }
                            else j = j + 1;

                        }
                        if (rows_val.Count > 0)
                        {
                            string rows_val_aqi_str = string.Empty;
                            string rows_val_str = string.Empty;

                            foreach (double val in rows_val)
                            {
                                rows_val_str += val.ToString("N2").Replace(',', '.') + ',';
                                rows_val_aqi_str += dailyPM2AQI(val).ToString("N2").Replace(',', '.') + ',';
                            }
                            rows_val_str = rows_val_str.Remove(rows_val_str.Length - 1);
                            rows_val_aqi_str = rows_val_aqi_str.Remove(rows_val_str.Length - 1);



                            int insertVal = await _datacontext.InsertGeotiffVal(result.Time.Year, i, geos[0], (geos[0] + cols * geos[1]), (geos[3] + (i + 1) * geos[5]), (geos[3] + (i) * geos[5]), rows_val_str, item.CategoryId, rows_val_aqi_str);


                        }


                    }

                }
                

            }
            int result2 = await _context.SaveChangesAsync();
            if (result2 > 0)
            {
                serviceResult.OnSuccess(result2, "Thay đổi thành công");
                return serviceResult;
            }
            serviceResult.OnError(result2, "Thay đổi không thành công");
            return serviceResult;
        }


        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
    
            var item = await _context.AComponentGeotiffDailies.FirstOrDefaultAsync(x => x.CategoryId == id);
            if(item == null)
            {
                serviceResult.OnError(0, "Không tìm thấy ảnh");
                return serviceResult;
            }
            await _storageService.DeleteFileAsync(item.Filename);
            _context.Remove(item);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                serviceResult.OnSuccess(result, "Xóa thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Xóa không thành công");
            return serviceResult;
        }

        public async Task<ServiceResult> Deletes(string[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            var items = await _context.AComponentGeotiffDailies.Where(x => ids.Contains(x.CategoryId)).ToListAsync();
            if (items.Count == 0)
            {
                serviceResult.OnError(0, "Không tìm thấy ảnh");
                return serviceResult;
            }
            foreach (var item in items){
                await _storageService.DeleteFileAsync(item.Filename);
            }
            _context.RemoveRange(items);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                serviceResult.OnSuccess(result, "Xóa thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Xóa không thành công");
            return serviceResult;
        }

        /// <summary>
        /// Lấy ảnh theo trang
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<PagedResult<GeotiffDailyModel>> PaginationAsync(GeotiffDailyModel paging)
        {
            var query = from p in _context.AComponentGeotiffDailies
                        join c in _context.AGroupComponents on p.GroupcomponentId equals c.Id 
                        join a in _context.AComponents on c.ComponentId equals a.Id into ci
                        from t in ci.DefaultIfEmpty()
                        join gr in _context.AGroups on c.GroupId equals gr.Id into gp
                        from g in gp.DefaultIfEmpty()

                        select new { p, c,g,t};

            if (!string.IsNullOrEmpty(paging.Keyword))
            {
                query = query.Where(x => x.p.Filename.ToLower().Contains(paging.Keyword.ToLower()));
            }
            if (!string.IsNullOrEmpty(paging.Filename))
            {
                query = query.Where(x => x.p.Filename.ToLower().Contains(paging.Filename.ToLower()));
            }
            if (!string.IsNullOrEmpty(paging.Tableindex))
            {
                query = query.Where(x => x.p.Tableindex.ToLower().Contains(paging.Tableindex.ToLower()));
            }
            if (!string.IsNullOrEmpty(paging.Tablename))
            {
                query = query.Where(x => x.p.Tablename.ToLower().Contains(paging.Tablename.ToLower()));
            }
            query = query.Where(x => x.c.ComponentId == "pm25");
          
            query = query.OrderByDescending(x => x.p.Modifydate.HasValue).ThenByDescending(x => x.p.Modifydate).ThenByDescending(x => x.p.DateShooting);
            int totalRow = await query.CountAsync();
            var data = await query.Skip((paging.PageIndex - 1) * paging.PageSize)
                .Take(paging.PageSize).Select(x => new GeotiffDailyModel()
                {
                    GroupcomponentId = x.p.GroupcomponentId,
                    DateShooting = x.p.DateShooting,
                    Tablename = x.p.Tablename,
                    Tableindex = x.p.Tableindex,
                    Filename = x.p.Filename,
                    MinX = x.p.MinX,
                    MaxX = x.p.MaxX,
                    MinY = x.p.MinX,
                    MaxY = x.p.MaxY,
                    ResolutionX = x.p.ResolutionX,
                    ResolutionY = x.p.ResolutionY,
                    Projectioncode = x.p.Projectioncode,
                    Modifydate = x.p.Modifydate,
                    CategoryId = x.p.CategoryId,
                    Groupcomponentname = x.t.Name + " - " + x.g.Name
                })
                .ToListAsync();

            var pagedResult = new PagedResult<GeotiffDailyModel>()
            {
                TotalRecords = totalRow,
                PageSize = paging.PageSize,
                PageIndex = paging.PageIndex,
                Items = data
            };
            return pagedResult;

        }

        //public async Task<StringBuilder> Export(string userName, SPagingRequest paging)
        //{
        //    var query = from p in _context.Stations
        //                join g in _context.GroupStations on p.Type equals g.ID
        //                select new { p, g };

        //    if (!string.IsNullOrEmpty(paging.Keyword))
        //    {
        //        query = query.Where(x => x.p.Name.ToLower().Contains(paging.Keyword.ToLower()));
        //    }
        //    if (!string.IsNullOrEmpty(paging.Name))
        //    {
        //        query = query.Where(x => x.p.Name.ToLower().Contains(paging.Name.ToLower()));
        //    }
        //    if (paging.Type != null && paging.Type != 0)
        //    {
        //        query = query.Where(x => x.p.Type == paging.Type);
        //    }
        //    var items = await query.ToListAsync();
        //    var builder = new StringBuilder();
        //    builder.AppendLine($"ID,Name,Lat,Lon,GroupStation,ProvinceID");
        //    foreach (var item in items)
        //    {
        //        builder.AppendLine($"{item.p.ID},{item.p.Name},{item.p.Lat},{item.p.Lon},{item.g.Name},{item.p.ProvinceID}");
        //    }
        //    builder.AppendLine($"Export by:,{userName}");
        //    return builder;


        //}

        /// <summary>
        /// Lấy all
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<ServiceResult> GetAll()
        {
            var items = await _context.AComponentGeotiffDailies.Where(x => true).ToListAsync();
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.OnSuccess(items);
                
            return serviceResult;

        }

        public int dailyPM2AQI(double pm25)
        {
            int[] BP = { 0, 25, 50, 80, 150, 250, 350, 500 };
            int[] I = { 0, 50, 100, 150, 200, 300, 400, 500 };
            int idx = 0;
            for (int i = 0; i < BP.Length; i++)
            {
                if (pm25 > BP[i]){
                    idx = i;
                }
                    
            }
            int aqi = (int)Math.Round((pm25 - BP[idx]) / (BP[idx + 1] - BP[idx]) * (I[idx + 1] - I[idx]) + I[idx]);

            return aqi;
        }





    }
}
