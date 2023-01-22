using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.Service2.ManageStation
{
    public interface IAComponentGeotiffDailyService
    {
        Task<ServiceResult> GetById(string id);

        Task<ServiceResult> Update(string id, IFormFile formImage);

        Task<ServiceResult> Create(List<IFormFile> formImage);

        Task<PagedResult<GeotiffDailyModel>> PaginationAsync(GeotiffDailyModel paging);

        Task<ServiceResult> Delete(string id);

        Task<ServiceResult> Deletes(string[] ids);

        Task<ServiceResult> GetAll();
    }
}
