using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.Service2.ManageStation;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.BackendManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupComponentsController : ControllerBase
    {
        private readonly IAGroupComponentService _aGroupComponentService;

        public GroupComponentsController(IAGroupComponentService aGroupComponentService)
        {
            _aGroupComponentService = aGroupComponentService;

        }

        [HttpPost]
        public async Task<ServiceResult> Create([FromBody] GroupComponentModel group)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupComponentService.Create(group);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPut("{id}")]

        public async Task<ServiceResult> Update(string id, [FromBody] GroupComponentModel group)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupComponentService.Update(id, group);
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
                serviceResult = await _aGroupComponentService.Delete(id);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPost("deletes")]
        public async Task<ServiceResult> Deletes(string[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aGroupComponentService.Deletes(ids);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        //[HttpGet("page")]
        ////[Authorize]
        //public async Task<ServiceResult> PaginationAsync([FromQuery] GSPagingRequest paging)
        //{
        //    ServiceResult serviceResult = new ServiceResult();
        //    try
        //    {
        //        serviceResult.OnSuccess(await _groupStationService.PaginationAsync(paging));
        //    }
        //    catch (Exception e)
        //    {
        //        serviceResult.OnError(new PagedResult<GroupComponentStation>(), "Có lỗi xảy ra");
        //    }
        //    return serviceResult;
        //}

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ServiceResult> GetById(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupComponentService.GetById(id));
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("all")]
        //[Authorize]
        public async Task<ServiceResult> GetAll()
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aGroupComponentService.GetAll());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }
    }
}
