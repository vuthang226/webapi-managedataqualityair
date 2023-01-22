using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.Entities;
using Web.ViewModel2.Common;
using Web.ViewModel2.ManageStation;

namespace Web.Service2.ManageStation
{
    public interface IAGroupComponentService
    {
        Task<ServiceResult> GetById(string id);

        Task<ServiceResult> Create(GroupComponentModel group);

        Task<ServiceResult> Update(string id, GroupComponentModel group);

        Task<ServiceResult> Delete(string id);

        Task<ServiceResult> Deletes(string[] ids);

        Task<ServiceResult> GetAll();
    }
}
