using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.Service2.ManageStation;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation.StationDaily;

namespace Web.BackendManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentStationDailiesController : ControllerBase
    {
        private readonly IAComponentStationDailyService _aComponentStationDailyService;

        public ComponentStationDailiesController(IAComponentStationDailyService aComponentStationDailyService)
        {
            _aComponentStationDailyService = aComponentStationDailyService;

        }

        [HttpPost]
        public async Task<ServiceResult> Create([FromBody] StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentStationDailyService.Create(daily);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPut("{id}")]

        public async Task<ServiceResult> Update(int id, [FromBody] StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentStationDailyService.Update(id, daily);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpDelete("{id}")]

        public async Task<ServiceResult> Delete(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentStationDailyService.Delete(id);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPost("deletes")]
        public async Task<ServiceResult> Deletes(int[] ids)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentStationDailyService.Deletes(ids);
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
        //        serviceResult.OnError(new PagedResult<ComponentStationDailyStation>(), "Có lỗi xảy ra");
        //    }
        //    return serviceResult;
        //}

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ServiceResult> GetById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aComponentStationDailyService.GetById(id));
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
                serviceResult.OnSuccess(await _aComponentStationDailyService.GetAll());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("page")]
        //[Authorize]
        public async Task<ServiceResult> GetDataStationDailyByPage([FromQuery]StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aComponentStationDailyService.PaginationAsync(daily));
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("export")]
        //[Authorize]
        public async Task<ActionResult> ExportData([FromQuery]StationDailyModel daily)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                StringBuilder builder = await _aComponentStationDailyService.Export(daily);
               
                
                
                return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv");
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return BadRequest();
        }

        [HttpPost("import")]
        public async Task<ServiceResult> ImportCsv([FromForm] SDImportRequest import)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentStationDailyService.ImportCsvFile( import);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }
    }
}
