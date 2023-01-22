using System;
using System.Collections.Generic;
using System.Text;
using Web.ViewModel2.Common;

namespace Web.ViewModel2.ManageStation
{
    public class GroupComponentModel : PagingRequestBase
    {
        public string GroupId { get; set; }
        public string ComponentId { get; set; }
        public bool? Isshow { get; set; }
        public bool? Isactive { get; set; }
        public int? Ordercomponent { get; set; }
        public string UserId { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string Id { get; set; }
    }
}
