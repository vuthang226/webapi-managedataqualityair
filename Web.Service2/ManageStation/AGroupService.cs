using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.EF;
using Web.Data2.Entities;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.Service2.ManageStation
{
    public class AGroupService:IAGroupService
    {
        private readonly apom_app_svContext _context;
        public AGroupService(apom_app_svContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lấy dữu liệu theo id (done)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>data: agroup</returns>
        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AGroups.FirstOrDefaultAsync(x => x.Id == id);
            serviceResult.OnSuccess(item);
            return serviceResult;
        }

        /// <summary>
        /// Lấy dữu liệu theo id (done)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>data: agroup</returns>
        public async Task<ServiceResult> GetStationById(string id)
        {
            var query = from p in _context.AGroups
               
                        join l in _context.GisAStations on p.Id equals l.GroupId into location
                        from le in location.DefaultIfEmpty()
                        select new { p, le };
            query = query.Where(x => x.p.Id == id);
            ServiceResult serviceResult = new ServiceResult();
            var data = await query.Select(x => new StationModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,

            
                ParentId = x.p.ParentId,
                Des = x.p.Des,

                CoorX = x.le.CoorX,
                CoorY = x.le.CoorY,
                Modifydate = x.p.Modifydate


            }).FirstAsync();
            serviceResult.OnSuccess(data);
            return serviceResult;
        }

        /// <summary>
        /// Tạo trạm con (done)
        /// </summary>
        /// <param name="station">dữ liệu, mô tả, tên và địa lý</param>
        /// <returns>mess:thông báo</returns>
        public async Task<ServiceResult> CreateStation(StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
          
            //check parent id
            if (String.IsNullOrEmpty(station.ParentId))
            {
                serviceResult.OnError(0, "Tạo không thành công");
                return serviceResult;
            }  
            //ckeck parentid exists
            var parent = await _context.AGroups.FirstOrDefaultAsync(x => x.Id == station.ParentId);
            if (parent == null)
            {
                serviceResult.OnError(0, "Trạm cha không tồn tại");
                return serviceResult;
            }
            else if (parent.ParentId != "station_airpolution" && parent.ParentId != "station_weather")
            {
                serviceResult.OnError(0, "Trạm cha không phù hợp");
                return serviceResult;
            }
            station.Id = Guid.NewGuid().ToString();
            var item = new AGroup
            {
                Id = station.Id,
                Name = station.Name,
                ParentId = station.ParentId,
                UserId = null,
                Des = station.Des,
                DesEn = RemoveUnicode(station.Des),
                NameEn = RemoveUnicode(station.Name),
                Icon = null,
                Isaqi = parent.Isaqi,
                Isactive = parent.Isactive,
                IslayerModel = false,
                IsstationWeather = parent.IsstationWeather,
                Isgroup = false,
                Isstation = true,
                Createdate = DateTime.Now,
                Modifydate = DateTime.Now,
            };
            await _context.AGroups.AddAsync(item);
            
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                GisAStation newLoca = new GisAStation
                {
                    GroupId = station.Id,
                    CoorX = station.CoorX,
                    CoorY = station.CoorY
                };
                if (station.CoorY.HasValue && station.CoorX.HasValue)
                {
                    newLoca.Geom = new Point((double)station.CoorX, (double)station.CoorY);
                }
                await _context.GisAStations.AddAsync(newLoca);
                    int result2 = await _context.SaveChangesAsync();
                if (result2 > 0)
                {
                    serviceResult.OnSuccess(result, "Tạo thành công");
                    return serviceResult;
                }
                else
                {
                    serviceResult.OnError(result, "Thêm vị trí địa lý không thành công");
                    return serviceResult;
                }
                
            }
            serviceResult.OnError(result, "Tạo không thành công");
            return serviceResult;
        }

        /// <summary>
        /// Tạo trạm cha, nhóm trạm (done)
        /// </summary>
        /// <param name="station">dữ liệu, mô tả, tên</param>
        /// <returns>mess:thông báo</returns>
        public async Task<ServiceResult> CreateGroupStation(StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            Random random = new Random();
            //check parent id
            if (String.IsNullOrEmpty(station.ParentId))
            {
                serviceResult.OnError(0, "Tạo không thành công");
                return serviceResult;
            }

            var IsWeather = false;
            if (station.ParentId == "station_weather") {
                IsWeather = true;
            } else if (station.ParentId == "station_airpolution")
            {
                IsWeather = false;
            }
            else
            {
                serviceResult.OnError(0, "Tạo không thành công");
                return serviceResult;
            }

            var item = new AGroup
            {
                Id = Guid.NewGuid().ToString(),
                Name = station.Name,
                ParentId = station.ParentId,
                UserId = null,
                Des = station.Des,
                DesEn = RemoveUnicode(station.Des),
                NameEn = RemoveUnicode(station.Name),
                Icon = null,
                Isaqi = false,
                Isactive = false,
                IslayerModel = false,
                IsstationWeather = IsWeather,
                Isgroup = true,
                Isstation = false,
                Createdate = DateTime.Now,
                Modifydate = DateTime.Now,
            };
            await _context.AGroups.AddAsync(item);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                serviceResult.OnSuccess(result, "Tạo thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Tạo không thành công");
            return serviceResult;
        }

        /// <summary>
        /// update trạm con và cha (done)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public async Task<ServiceResult> Update( string id, StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AGroups.FirstOrDefaultAsync(x => x.Id == id);
            if(item == null)
            {
                serviceResult.OnError(0, "Trạm không tồn tại");
                return serviceResult;
            }
            //check du lieu dưới là trạm con cập nhật thành trạm lớn (không cho phép)
            if((item.ParentId != "station_airpolution" && item.ParentId != "station_weather" ) &&(station.ParentId == "station_airpolution" || station.ParentId == "station_weather"))
            {
                serviceResult.OnError(0, "Không được chuyển trạm không cùng cấp");
                return serviceResult;
            }
            else if ((item.ParentId == "station_airpolution" || item.ParentId == "station_weather") && (station.ParentId != "station_airpolution" && station.ParentId != "station_weather"))
            {
                serviceResult.OnError(0, "Không được chuyển trạm không cùng cấp");
                return serviceResult; 
            }
            item.ParentId = station.ParentId;
            if (item.ParentId != "station_airpolution" && item.ParentId != "station_weather")
            {
      
                var loca = await _context.GisAStations.FirstOrDefaultAsync(x => x.GroupId == item.Id);
                loca.CoorY = station.CoorY;
                loca.CoorX = station.CoorX;
                
                if(station.CoorY.HasValue && station.CoorX.HasValue)
                {
                    loca.Geom = new Point((double)station.CoorX, (double)station.CoorY);
                }
                


            } else if (item.ParentId == "station_airpolution")
            {
                item.IsstationWeather = false;
            } else if (item.ParentId == "station_weather")
            {
                item.IsstationWeather = true;
            }
            
            item.Name = station.Name;
            item.NameEn = RemoveUnicode(station.Name);
            item.Modifydate = DateTime.Now;
            item.Des = station.Des;
            item.DesEn = RemoveUnicode(station.Des);
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
        /// Xóa trạm cha, con (done)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AGroups.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null)
            {
                serviceResult.OnError(0, "Trạm không tồn tại");
                return serviceResult;
            }
            if (item.ParentId != "station_airpolution" && item.ParentId != "station_weather")
            {
                var loca = await _context.GisAStations.FirstOrDefaultAsync(x => x.GroupId == item.Id);
                if(loca != null)
                {
                    _context.Remove(loca);
                }

            }
            else
            {
                var items = await _context.AGroups.Where(x => x.ParentId == id).ToListAsync();
                string[] listId = items.Select(x => x.Id).ToArray();
                var locas = await _context.GisAStations.Where(x => listId.Contains(x.GroupId)).ToListAsync();
                _context.GisAStations.RemoveRange(locas);
                _context.AGroups.RemoveRange(items);
            }

            _context.AGroups.Remove(item);
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
        /// Xóa nhiều trạm cha và con (done)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<ServiceResult> Deletes(string[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            var items = await _context.AGroups.Where(x => ids.Contains(x.Id)).ToListAsync();
            if ((items.Exists(x => x.ParentId == "station_airpolution") || items.Exists(x => x.ParentId == "station_weather")) && (items.Exists(x => x.ParentId != "station_airpolution") && items.Exists(x => x.ParentId != "station_weather")))
            {
                serviceResult.OnError(0, "Dữ liệu cùng cấp chuẩn xóa không thành công");
                return serviceResult;
            }
            else if (items.Exists(x => x.ParentId != "station_airpolution") && items.Exists(x => x.ParentId != "station_weather"))
            {
                var locas = await _context.GisAStations.FirstOrDefaultAsync(x => ids.Contains(x.GroupId));
                _context.GisAStations.RemoveRange(locas);
            }
            else
            {
                for (int i = 0; i < ids.Length; i++)
                {
                    var stations = await _context.AGroups.Where(x => x.ParentId == ids[i]).ToListAsync();
                    string[] listId = stations.Select(x => x.Id).ToArray();
                    var locas = await _context.GisAStations.Where(x => listId.Contains(x.GroupId)).ToListAsync();
                    _context.GisAStations.RemoveRange(locas);
                    _context.AGroups.RemoveRange(stations);
                }
                
            }
            _context.AGroups.RemoveRange(items);
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
        public async Task<PagedResult<StationModel>> PaginationStationsAsync(StationModel station)
        {
            var query = from p in _context.AGroups
                        join  l in _context.GisAStations on p.Id equals l.GroupId into location
                        from le in location.DefaultIfEmpty()
                        join g in _context.AGroups on p.ParentId equals g.Id into parent
                        from ge in parent.DefaultIfEmpty()
                        select new { p,le,ge};
            //Chi chon station station_weather và station_airpolution
            query = query.Where(x => x.ge.ParentId == "station_weather" || x.ge.ParentId == "station_airpolution");


            if (!string.IsNullOrEmpty(station.Id))  
            {
                query = query.Where(x => x.p.Id.ToLower() == station.Id.ToLower());
            }
            if (!string.IsNullOrEmpty(station.ParentId))
            {
                query = query.Where(x => x.p.ParentId.ToLower() == station.ParentId.ToLower());
            }
            if (!string.IsNullOrEmpty(station.Name))
            {
                query = query.Where(x => x.p.Name.ToLower().Contains(station.Name.ToLower()));
            }if (!string.IsNullOrEmpty(station.Des))
            {
                query = query.Where(x => x.p.Des.ToLower().Contains(station.Des.ToLower()));
            }
            
            
            query = query.OrderByDescending(x => x.p.Modifydate.HasValue).ThenByDescending(x => x.p.Modifydate);
            int totalRow = await query.CountAsync();
            var data = await query.Skip((station.PageIndex - 1) * station.PageSize)
                .Take(station.PageSize).Select(x => new StationModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
   
                    ParentName = x.ge.Name,
                    ParentId = x.p.ParentId,
                    Des = x.p.Des,
          
                    CoorX = x.le.CoorX,
                    CoorY = x.le.CoorY,
                    Modifydate = x.p.Modifydate
                    //Geom = x.le.Geom.ToString()

                })
                .ToListAsync();
            
            var pagedResult = new PagedResult<StationModel>()
            {
                TotalRecords = totalRow,
                PageSize = station.PageSize,
                PageIndex = station.PageIndex,
                Items = data
            };
            return pagedResult;

        }

        public async Task<PagedResult<StationModel>> PaginationGroupStationsAsync(StationModel station)
        {
            var query = from p in _context.AGroups
                        join g in _context.AGroups on p.ParentId equals g.Id

                        select new { p,g };

            if (!string.IsNullOrEmpty(station.Id))
            {
                query = query.Where(x => x.p.Id.ToLower() == station.Id.ToLower());
            }
            if (!string.IsNullOrEmpty(station.ParentId) &&(station.ParentId == "station_weather" || station.ParentId == "station_airpolution"))
            {
                query = query.Where(x => x.p.ParentId.ToLower() == station.ParentId.ToLower());
            }
            if (!string.IsNullOrEmpty(station.Name))
            {
                query = query.Where(x => x.p.Name.ToLower().Contains(station.Name.ToLower()));
            }
            if (!string.IsNullOrEmpty(station.Des))
            {
                query = query.Where(x => x.p.Des.ToLower().Contains(station.Des.ToLower()));
            }
            query = query.Where(x => x.p.ParentId == "station_weather" || x.p.ParentId == "station_airpolution");

            query = query.OrderByDescending(x => x.p.Modifydate.HasValue).ThenByDescending( x => x.p.Modifydate);

            int totalRow = await query.CountAsync();
            var data = await query.Skip((station.PageIndex - 1) * station.PageSize)
                .Take(station.PageSize).Select(x => new StationModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    ParentName = x.g.Name,
                    Des = x.p.Des,
                    Modifydate = x.p.Modifydate

                })
                .ToListAsync();

            var pagedResult = new PagedResult<StationModel>()
            {
                TotalRecords = totalRow,
                PageSize = station.PageSize,
                PageIndex = station.PageIndex,
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
        /// Lấy all gstation
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<ServiceResult> GetAllGStation()
        {
            ServiceResult serviceResult = new ServiceResult();
            var i = await _context.AGroups.Where(x=>x.ParentId == "station_airpolution" || x.ParentId == "station_weather").ToListAsync();
            serviceResult.OnSuccess(i);
            return serviceResult;
        }

        /// <summary>
        /// Lấy all station
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        public async Task<ServiceResult> GetAllStation()
        {
            var query = from p in _context.AGroups
                        join g in _context.AGroups on p.ParentId equals g.Id
                        join l in _context.GisAStations on p.Id equals l.GroupId into location
                        from le in location.DefaultIfEmpty()
                        select new { p, g,le };
            query = query.Where(x => x.g.ParentId == "station_airpolution" || x.g.ParentId == "station_weather");
            ServiceResult serviceResult = new ServiceResult();
            var data = await query.Take(await query.CountAsync()).Select(x => new StationModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                Des = x.p.Name + " - " + x.p.Des,
                CoorX = x.le.CoorX,
                CoorY = x.le.CoorY, 
                

            }).ToListAsync();
            
            serviceResult.OnSuccess(data);
            return serviceResult;
        }


        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
