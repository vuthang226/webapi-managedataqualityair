using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.ViewModel2.Common;

namespace Web.Service2.ManageStation
{
    public interface IAComponentService
    {
        Task<ServiceResult> GetById(string id);

        Task<ServiceResult> Update(string id, AComponent component);

        Task<ServiceResult> Delete(string id);

        Task<ServiceResult> Deletes(string[] ids);

        Task<ServiceResult> GetAll();
    }
}
