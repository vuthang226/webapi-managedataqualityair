using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.Service2.Common;
using Web.Service2.ManageStation;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.BackendManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentGeotiffDailiesController : ControllerBase
    {
        private readonly IAComponentGeotiffDailyService _aComponentGeotiffDailyService;
        private readonly IStorageService _store;

        public ComponentGeotiffDailiesController(IAComponentGeotiffDailyService aComponentGeotiffDailyService, IStorageService store)
        {
            _aComponentGeotiffDailyService = aComponentGeotiffDailyService;
            _store = store;
        }

        [HttpPost]
        public async Task<ServiceResult> Create([FromForm] List<IFormFile> formImage)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentGeotiffDailyService.Create(formImage);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }


        [HttpPut("{id}")]

        public async Task<ServiceResult> Update(string id, [FromForm] IFormFile formImage)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentGeotiffDailyService.Update(id, formImage);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("image")]
 
        public IActionResult GetImage(string pathImage)
        {

            //try
            //{

            string path = _store.GetFileUrl(pathImage);
            Byte[] b = System.IO.File.ReadAllBytes(path);
            return File(b, "image/tiff");

            //}
            //catch (Exception e)
            //{
            //    serviceResult.HandleException(e, "Có lỗi xảy ra");
            //}
            //return serviceResult;
        }


        [HttpDelete("{id}")]

        public async Task<ServiceResult> Delete(string id)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = await _aComponentGeotiffDailyService.Delete(id);
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
                serviceResult = await _aComponentGeotiffDailyService.Deletes(ids);
            }
            catch (Exception e)
            {
                serviceResult.HandleException(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }

        [HttpGet("page")]
        //[Authorize]
        public async Task<ServiceResult> PaginationAsync([FromQuery] GeotiffDailyModel paging)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult.OnSuccess(await _aComponentGeotiffDailyService.PaginationAsync(paging));
            }
            catch (Exception e)
            {
                serviceResult.OnError(new PagedResult<AComponentGeotiffDaily>(), "Có lỗi xảy ra");
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
                serviceResult.OnSuccess(await _aComponentGeotiffDailyService.GetById(id));
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
                serviceResult.OnSuccess(await _aComponentGeotiffDailyService.GetAll());
            }
            catch (Exception e)
            {
                serviceResult.OnError(e, "Có lỗi xảy ra");
            }
            return serviceResult;
        }
    }
}
