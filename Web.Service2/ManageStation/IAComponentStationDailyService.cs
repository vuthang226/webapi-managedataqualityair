using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation.StationDaily;

namespace Web.Service2.ManageStation
{
    public interface IAComponentStationDailyService
    {
        Task<ServiceResult> GetById(int id);

        Task<ServiceResult> Create(StationDailyModel daily);

        Task<ServiceResult> Update(int id, StationDailyModel daily);

        Task<ServiceResult> Delete(int id);

        Task<ServiceResult> Deletes(int[] ids);

        Task<StringBuilder> Export(StationDailyModel paging);

        Task<PagedResult<StationDailyModel>> PaginationAsync(StationDailyModel paging);

        Task<ServiceResult> ImportCsvFile(SDImportRequest import);

        Task<ServiceResult> GetAll();
    }
}
