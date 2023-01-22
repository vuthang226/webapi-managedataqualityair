using System;
using System.Collections.Generic;
using System.Text;

namespace Web.ViewModel2.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}
