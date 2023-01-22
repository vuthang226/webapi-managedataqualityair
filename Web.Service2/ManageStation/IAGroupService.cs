using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.Service2.ManageStation
{
    public interface IAGroupService
    {
        Task<ServiceResult> GetById(string id);

        Task<ServiceResult> GetStationById(string id);

        Task<ServiceResult> CreateStation(StationModel station);

        Task<ServiceResult> CreateGroupStation(StationModel station);

        Task<ServiceResult> Update( string id, StationModel station);

        Task<ServiceResult> Delete(string id);

        Task<ServiceResult> Deletes(string[] ids);

        Task<ServiceResult> GetAllStation();

        Task<ServiceResult> GetAllGStation();

        Task<PagedResult<StationModel>> PaginationStationsAsync(StationModel station);

        Task<PagedResult<StationModel>> PaginationGroupStationsAsync(StationModel station);
    }
}
