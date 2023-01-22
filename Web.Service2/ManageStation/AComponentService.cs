using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.EF;
using Web.Data2.Entities;
using Web.ViewModel2.Common;

namespace Web.Service2.ManageStation
{
    public class AComponentService: IAComponentService
    {
        private readonly apom_app_svContext _context;
        public AComponentService(apom_app_svContext context)
        {
            _context = context;
        }

        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AComponents.FirstOrDefaultAsync(x => x.Id == id);
            serviceResult.OnSuccess(item);
            return serviceResult;
        }

        /// <summary>
        /// Tảo trạm
        /// </summary>
        /// <param name="userId">id người tạo</param>
        /// <param name="group">thông số nhóm trạm</param>
        /// <returns></returns>
        //public async Task<ServiceResult> Create(AComponent group)
        //{
        //    ServiceResult serviceResult = new ServiceResult();
        //    var item = new AGroup
        //    {

        //    };
        //    await _context.AGroups.AddAsync(group);

        //    int result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {

        //        serviceResult.OnSuccess(result, "Tạo thành công");
        //        return serviceResult;
        //    }
        //    serviceResult.OnError(result, "Tạo không thành công");
        //    return serviceResult;
        //}


        public async Task<ServiceResult> Update(string id, AComponent component)
        {
            ServiceResult serviceResult = new ServiceResult();
            var item = await _context.AComponents.FirstOrDefaultAsync(x => x.Id == id);

            item.Des = component.Des;
            item.DesEn = component.DesEn;
            item.Name = component.Name;
            item.NameEn = component.NameEn;
            item.Icon = component.Icon;
            item.UserId = component.UserId;
            item.LegendDesEn = component.LegendDesEn;
            item.LegendImg = component.LegendImg;   
            item.UserId = component.LegendDes;
            item.Modifydate = DateTime.Now;
            item.Des = component.Des;
            item.DesEn = component.DesEn;
            item.Icon = component.Icon;

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
            var item = await _context.AGroups.FirstOrDefaultAsync(x => x.Id == id);

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
            var items = await _context.AGroups.Where(x => ids.Contains(x.Id)).ToListAsync();

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
            var items = await _context.AComponents.Where(x => true).ToListAsync();
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.OnSuccess(items);

            return serviceResult;

        }
    }
}
