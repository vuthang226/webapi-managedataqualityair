using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.Service2.ManageStation;
using Web.ViewModel2.Common;

namespace Web.BackendManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        private readonly IAComponentService _componentService;
        
        public ComponentsController(IAComponentService componentService)
        {
            _componentService = componentService;
       
        }



        //[HttpPost]
        //[Authorize]
        //public async Task<ServiceResult> Create([FromBody] AComponent station)
        //{
        //    ServiceResult serviceResult = new ServiceResult();
        //    try
        //    {
        //        serviceResult = await _componentService.Create( station);
        //    }
        //    catch (Exception e)
        //    {
        //        serviceResult.HandleException(e, "Có lỗi xảy ra");
        //    }
        //    return serviceResult;
        //}


        [HttpPut("{id}")]
        [Authorize]
        public async Task<ServiceResult> Update(string id, [FromBody] AComponent component)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _componentService.Update( id, component);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _componentService.Delete(id);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPost("deletes")]
        [Authorize]
        public async Task<ServiceResult> Deletes(string[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _componentService.Deletes(ids);
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
        //        serviceResult.OnSuccess(await _componentService.PaginationAsync(paging));
        //    }
        //    catch (Exception e)
        //    {
        //        serviceResult.OnError(new PagedResult<Component>(), "Có lỗi xảy ra");
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
                serviceResult.OnSuccess(await _componentService.GetById(id));
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
                serviceResult.OnSuccess(await _componentService.GetAll());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        //[HttpGet("Export")]
        //[Authorize]
        //public async Task<ActionResult> Export([FromQuery] GSPagingRequest paging)
        //{

        //    try
        //    {
        //        ServiceResult result = await _componentService.Export(await _workContext.GetUserName(), paging);
        //        StringBuilder builder = new StringBuilder();
        //        builder.Append(result.Data.ToString());
        //        return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", result.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e);
        //    }

        //}
    }
}
