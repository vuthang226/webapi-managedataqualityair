using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.EF;
using Web.Data2.Entities;
using Web.Service2.MapData;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation.StationDaily;

namespace Web.Service2.ManageStation
{
    public class AComponentStationDailyService: IAComponentStationDailyService
    {
        private readonly apom_app_svContext _context;
        public AComponentStationDailyService(apom_app_svContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lấy dữ liệu bằng id (done)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult> GetById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AComponentStationDailies.FirstOrDefaultAsync(x => x.Oid == id);
            serviceResult.OnSuccess(item);
            return serviceResult;
        }

        /// <summary>
        /// Tạo dữ liệu mới (done)
        /// </summary>
        /// <param name="userId">id người tạo</param>
        /// <param name="group">thông số nhóm trạm</param>
        /// <returns></returns>
        public async Task<ServiceResult> Create(StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            var isStation = await _context.AGroups.AnyAsync();
            if (!isStation)
            {
                serviceResult.OnSuccess(0, "Không tìm thấy id trạm");
                return serviceResult;
            }
            string jsonData = "{\"co\": " + daily.Co + ",\"no2\": " + daily.No2 + ",\"pm10\": " + daily.Pm10 + ",\"pm25\": " +daily.Pm25 + ",\"o3\":" + daily.O3+ ",\"so2\":" + daily.So2+"}";
            
            var item = new AComponentStationDaily
            {
                GroupId = daily.GroupId,
                DatetimeShooting = daily.DatetimeShooting,
                DataShooting = jsonData,
                UserId = daily.UserId,
                Createdate = DateTime.Now,             
                Pm25 = daily.Pm25,
                AqiPm25 = daily.AqiPm25,
                Pm10 = daily.Pm10,
                AqiPm10 = daily.AqiPm10,
                Modifydate = DateTime.Now,
                No2 = daily.No2,
                AqiNo2 = daily.AqiNo2,
                Co = daily.Co,
                AqiCo = daily.AqiCo,
                So2 = daily.So2,
                AqiSo2 = daily.AqiSo2,
                O3 = daily.O3,
                AqiO3 = daily.AqiO3,
                Altm = daily.Altm,
                Temp = daily.Temp,
                Hud = daily.Hud,
                Wdir = daily.Wdir,
                Wspd = daily.Wspd,
                Vis = daily.Vis,
                Aqi = daily.Aqi,
            };
            await _context.AComponentStationDailies.AddAsync(item);

            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {

                serviceResult.OnSuccess(result, "Tạo thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Tạo không thành công");
            return serviceResult;
        }


        public async Task<ServiceResult> Update(int id, StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            
            var item = await _context.AComponentStationDailies.FirstOrDefaultAsync(x => x.Oid == id);
            if (item == null)
            {
                serviceResult.OnSuccess(0, "Không tìm thấy id trạm");
                return serviceResult;
            }
            string jsonData = "{\"co\": " + daily.Co + ",\"no2\": " + daily.No2 + ",\"pm10\": " + daily.Pm10 + ",\"pm25\": " + daily.Pm25 + ",\"o3\":" + daily.O3 + ",\"so2\":" + daily.So2 + "}";

            item.GroupId = daily.GroupId;
            item.DatetimeShooting = daily.DatetimeShooting;
            item.DataShooting = jsonData;
            item.UserId = daily.UserId;
            item.Pm25 = daily.Pm25;
            item.AqiPm25 = daily.AqiPm25;
            item.Pm10 = daily.Pm10;
            item.AqiPm10 = daily.AqiPm10;
            item.Modifydate = DateTime.Now;
            item.No2 = daily.No2;
            item.AqiNo2 = daily.AqiNo2;
            item.Co = daily.Co;
            item.AqiCo = daily.AqiCo;
            item.So2 = daily.So2;
            item.AqiSo2 = daily.AqiSo2;
            item.O3 = daily.O3;
            item.AqiO3 = daily.AqiO3;
            item.Altm = daily.Altm;
            item.Temp = daily.Temp;
            item.Hud = daily.Hud;
            item.Wdir = daily.Wdir;
            item.Wspd = daily.Wspd;
            item.Vis = daily.Vis;
            item.Aqi = daily.Aqi;
            

            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                serviceResult.OnSuccess(result, "Thay đổi thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Thay đổi không thành công");
            return serviceResult;
        }

        /// <summary>
        /// xóa (done)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult> Delete(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AComponentStationDailies.FirstOrDefaultAsync(x => x.Oid == id);
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

        /// <summary>
        /// xóa nhiều (done)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<ServiceResult> Deletes(int[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            var items = await _context.AComponentStationDailies.Where(x => ids.Contains(x.Oid)).ToListAsync();

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
        /// Lấy ảnh theo trang(done)
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<PagedResult<StationDailyModel>> PaginationAsync(StationDailyModel paging)
        {
            var query = from p in _context.AComponentStationDailies
                        join g in _context.AGroups on p.GroupId equals g.Id
                        select new { p, g };

            if (!string.IsNullOrEmpty(paging.Keyword))
            {
                query = query.Where(x => x.g.Name.ToLower().Contains(paging.Keyword.ToLower()));
            }
            if (!string.IsNullOrEmpty(paging.GroupId))
            {
                query = query.Where(x => x.p.GroupId.ToLower() == paging.GroupId.ToLower());
            }
            if (paging.DatetimeShooting != null && paging.DatetimeType == 0)
            {
                query = query.Where(x => x.p.DatetimeShooting  == paging.DatetimeShooting);
            }else if(paging.DatetimeShooting != null && paging.DatetimeType != 0)
            {
                query = query.Where(x => CompareDateTimes(x.p.DatetimeShooting, paging.DatetimeShooting) );
            }
            if (paging.Createdate != null )
            {
                query = query.Where(x => CompareDateTimes(x.p.Createdate,paging.Createdate));
            }
            query = query.OrderByDescending(x => x.p.Modifydate.HasValue).ThenByDescending( x => x.p.Modifydate).ThenByDescending(x=>x.p.DatetimeShooting);

            

            int totalRow = await query.CountAsync();
            var data = await query.Skip((paging.PageIndex - 1) * paging.PageSize)
                .Take(paging.PageSize).Select(x => new StationDailyModel()
                {
                    Oid = x.p.Oid,
                    GroupId = x.p.GroupId,
                    GroupName = x.g.Name,
                    DatetimeShooting = x.p.DatetimeShooting,
                    Createdate = x.p.Createdate,
                    Pm25 = x.p.Pm25,
                    AqiPm25 =  x.p.AqiPm25,
                    Pm10 = x.p.Pm10,
                    AqiPm10 = x.p.AqiPm10,
                    Co = x.p.Co,
                    AqiCo = x.p.AqiCo,
                    O3 = x.p.O3,
                    AqiO3 = x.p.AqiO3,
                    So2 = x.p.So2,
                    AqiSo2 = x.p.AqiSo2,
                    No2 = x.p.No2,
                    AqiNo2 = x.p.AqiNo2,
                    Altm = x.p.Altm,
                    Temp = x.p.Temp,
                    Hud = x.p.Hud,
                    Wdir = x.p.Wdir,
                    Wspd = x.p.Wspd,
                    Vis = x.p.Vis,
                })
                .ToListAsync();

            var pagedResult = new PagedResult<StationDailyModel>()
            {
                TotalRecords = totalRow,
                PageSize = paging.PageSize,
                PageIndex = paging.PageIndex,
                Items = data
            };
            return pagedResult;

        }

        public bool CompareDateTimes(DateTime? firstDate, DateTime? secondDate)
        {
            if (!firstDate.HasValue || !secondDate.HasValue) return false;
            return firstDate.Value.Day == secondDate.Value.Day && firstDate.Value.Month == secondDate.Value.Month && firstDate.Value.Year == secondDate.Value.Year;
        }

        /// <summary>
        /// Xuất dữ liệu ra csv (done)
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<StringBuilder> Export(StationDailyModel paging)
        {
            var query = from p in _context.AComponentStationDailies
                        join g in _context.AGroups on p.GroupId equals g.Id
                        select new { p, g };

            if (!string.IsNullOrEmpty(paging.Keyword))
            {
                query = query.Where(x => x.g.Name.ToLower().Contains(paging.Keyword.ToLower()));
            }
            if (!string.IsNullOrEmpty(paging.GroupId))
            {
                query = query.Where(x => x.p.GroupId.ToLower() == paging.GroupId.ToLower());
            }
            if (paging.DatetimeShooting != null && paging.DatetimeType == 0)
            {
                query = query.Where(x => x.p.DatetimeShooting == paging.DatetimeShooting);
            }
            else if (paging.DatetimeShooting != null && paging.DatetimeType != 0)
            {
                query = query.Where(x => CompareDateTimes(x.p.DatetimeShooting, paging.DatetimeShooting));
            }
            if (paging.Createdate != null)
            {
                query = query.Where(x => CompareDateTimes(x.p.Createdate, paging.Createdate));
            }
            query = query.OrderByDescending(x => x.p.Modifydate.HasValue).ThenByDescending(x => x.p.Modifydate).ThenByDescending(x => x.p.DatetimeShooting);

            var items = await query.Take(await query.CountAsync())
                .ToListAsync(); 
            var builder = new StringBuilder();
            builder.AppendLine($"ID,Group Name,Datetime Shooting,DataShooting,Createdate,Pm25,AqiPm25,Pm10,AqiPm10,No2,AqiNo2,Co,AqiCo,So2,AqiSo2,O3,AqiO3,Altm,Temp,Hud,Wdir,Wspd,Vis,Aqi");
            foreach (var item in items)
            {
                builder.AppendLine($"{item.p.Oid},{item.g.Name},{item.p.DatetimeShooting},{item.p.DataShooting},{item.g.Createdate},{item.p.Pm25},{item.p.AqiPm25},{item.p.Pm10},{item.p.AqiPm10},{item.p.No2},{item.p.AqiNo2},{item.p.Co},{item.p.AqiCo},{item.p.So2},{item.p.AqiSo2},{item.p.O3},{item.p.Altm},{item.p.Temp},{item.p.Hud},{item.p.Wdir},{item.p.Wspd},{item.p.Vis},{item.p.Aqi}");
            }
            
            return builder;


        }

        /// <summary>
        /// Lấy all (done)
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<ServiceResult> GetAll()
        {
            var items = await _context.AComponentStationDailies.Where(x => true).ToListAsync();
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.OnSuccess(items);

            return serviceResult;

        }

        /// <summary>
        /// import file csv station data (done)
        /// </summary>
        /// <param name="import"></param>
        /// <returns></returns>
        public async Task<ServiceResult> ImportCsvFile(SDImportRequest import)
        {
            ServiceResult serviceResult = new ServiceResult();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                Delimiter = ",",
                HeaderValidated = null,
                MissingFieldFound = null,
                //CultureInfo = CultureInfo.GetCultureInfo("en-GB")
            };


            using (var reader = new StreamReader(import.CsvFile.OpenReadStream()))
            using (var csv = new CsvReader(reader, config))
            {

                csv.Context.RegisterClassMap<SDMap>();
                var records = csv.GetRecords<AComponentStationDaily>().Select(c =>
                {
                    c.Createdate = DateTime.Now;
                    c.Modifydate = DateTime.Now;
                    c.GroupId = import.GroupId;
                    //c.DataShooting = "{\"co\": " + c.Co + ",\"no2\": " + c.No2 + ",\"pm10\": " + c.Pm10 + ",\"pm25\": " + c.Pm25 + ",\"o3\":" + c.O3 + ",\"so2\":" + c.So2 + "}";
                    return c;
                }).ToList();
                await _context.AComponentStationDailies.AddRangeAsync(records);
                //serviceResult.OnSuccess(await _context.SaveChangesAsync(), "Luu thanh cong");
            }


            serviceResult.OnSuccess(await _context.SaveChangesAsync(), "Luu thanh cong");

            return serviceResult;
        }
    }
}
