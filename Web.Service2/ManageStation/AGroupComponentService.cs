using Microsoft.EntityFrameworkCore;
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
    public class AGroupComponentService:IAGroupComponentService
    {
        private readonly apom_app_svContext _context;
        public AGroupComponentService(apom_app_svContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AGroupComponents.FirstOrDefaultAsync(x => x.Id == id);
            serviceResult.OnSuccess(item);
            return serviceResult;
        }

        /// <summary>
        /// Tảo trạm
        /// </summary>
        /// <param name="userId">id người tạo</param>
        /// <param name="group">thông số nhóm trạm</param>
        /// <returns></returns>
        public async Task<ServiceResult> Create(GroupComponentModel group)
        {
            ServiceResult serviceResult = new ServiceResult();
            var existGroup = await _context.AGroups.AnyAsync(x => x.Id == group.GroupId);
            var existComponent = await _context.AComponents.AnyAsync(x => x.Id == group.ComponentId);
            if(!existGroup)
            {
                serviceResult.OnError(0, "Không tồn tại nhóm trạm");
                return serviceResult;
            }else if(!existComponent)
            {
                serviceResult.OnError(0, "Không tồn tại loại dữ liệu");
                return serviceResult;
            }
            var item = new AGroupComponent
            {
                GroupId = group.GroupId,
                ComponentId = group.ComponentId,
                Isshow = true,
                Isactive = true,
                Ordercomponent = 1,
                Createdate = DateTime.Now,
                Modifydate = DateTime.Now

            };
            await _context.AGroupComponents.AddAsync(item);

            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {

                serviceResult.OnSuccess(result, "Tạo thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Tạo không thành công");
            return serviceResult;
        }


        public async Task<ServiceResult> Update(string id, GroupComponentModel group)
        {
            ServiceResult serviceResult = new ServiceResult();
            var existGroupComponent = await _context.AGroupComponents.AnyAsync(x => group.GroupId == x.GroupId && group.ComponentId == x.ComponentId && group.Id != x.Id);
            if (!existGroupComponent)
            {
                serviceResult.OnError(0, "Dữ liệu của nhóm trạm đã tồn tại");
                return serviceResult;
            }
            var item = await _context.AGroupComponents.FirstOrDefaultAsync(x => x.Id == id);

            item.GroupId = group.GroupId;
            item.ComponentId = group.ComponentId;
            //item.Isshow = group.Isshow;
            //item.Isactive = group.Isactive;
            //item.Ordercomponent = group.Ordercomponent;
            item.Modifydate = DateTime.Now;
            
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                serviceResult.OnSuccess(result, "Thay đổi thành công");
                return serviceResult;
            }
            serviceResult.OnError(result, "Thay đổi không thành công");
            return serviceResult;
        }


        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AGroupComponents.FirstOrDefaultAsync(x => x.Id == id);
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
            var items = await _context.AGroupComponents.Where(x => ids.Contains(x.Id)).ToListAsync();

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
        //public async Task<PagedResult<AGroup>> PaginationAsync(SPagingRequest paging)
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
        //    query.OrderByDescending(x => x.p.UpdatedAt);

        //    int totalRow = await query.CountAsync();
        //    var data = await query.Skip((paging.PageIndex - 1) * paging.PageSize)
        //        .Take(paging.PageSize).Select(x => new StationPm()
        //        {
        //            ID = x.p.ID,
        //            Lat = x.p.Lat,
        //            Lon = x.p.Lon,
        //            ProvinceID = x.p.ProvinceID,
        //            Type = x.p.Type,
        //            Name = x.p.Name,
        //            GroupStationName = x.g.Name,
        //        })
        //        .ToListAsync();

        //    var pagedResult = new PagedResult<StationPm>()
        //    {
        //        TotalRecords = totalRow,
        //        PageSize = paging.PageSize,
        //        PageIndex = paging.PageIndex,
        //        Items = data
        //    };
        //    return pagedResult;

        //}

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
            var items = await _context.AGroupComponents.Where(x => true).ToListAsync();
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.OnSuccess(items);

            return serviceResult;

        }
    }
}
