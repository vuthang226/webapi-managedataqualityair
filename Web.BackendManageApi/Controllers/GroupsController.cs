using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.Service2.ManageStation;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.BackendManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IAGroupService _aGroupService;
        
        public GroupsController(IAGroupService aGroupService)
        {
            _aGroupService = aGroupService;
            
        }

        [HttpPost("station")]       
        public async Task<ServiceResult> CreateStation([FromBody] StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupService.CreateStation(station);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }
        
        [HttpPost]
        public async Task<ServiceResult> CreateGroupStation([FromBody] StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupService.CreateGroupStation(station);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPut("{id}")]  
        public async Task<ServiceResult> Update(string id, [FromBody] StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupService.Update( id, station);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpDelete("{id}")]      
        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupService.Delete(id);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPost("deletes")]
        public async Task<ServiceResult> DeletesAsync(string[] listId)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupService.Deletes(listId);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("pageStation")]
        public async Task<ServiceResult> PaginationStationsAsync([FromQuery] StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();  
            try
            {
                serviceResult.OnSuccess(await _aGroupService.PaginationStationsAsync(station));
            }
            catch (Exception e)
            {
                serviceResult.OnError(new PagedResult<StationModel>(), "Có lỗi xảy ra");
            }
            return serviceResult;
        }
        
        [HttpGet("pageGStation")]
        public async Task<ServiceResult> PaginationGroupStationsAsync([FromQuery] StationModel station)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupService.PaginationGroupStationsAsync(station));
            }
            catch (Exception e)
            {
                serviceResult.OnError(new PagedResult<StationModel>(), "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupService.GetById(id));
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }[HttpGet("station/{id}")]
        //[Authorize]
        public async Task<ServiceResult> GetStationById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupService.GetStationById(id));
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("station/all")]
        //[Authorize]
        public async Task<ServiceResult> GetAllStation()
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupService.GetAllStation());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("all")]
        //[Authorize]
        public async Task<ServiceResult> GetAllGStation()
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupService.GetAllGStation());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }
    }
}
