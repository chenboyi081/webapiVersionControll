using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiVersionControll.Controllers.V2
{
    public partial class UserController : ApiControllerBase
    {
        // GET api/v2/user
        public IEnumerable<string> Get()
        {
            return new string[] { "我是第2版的User数据", "value1" };
        }
    }
}
