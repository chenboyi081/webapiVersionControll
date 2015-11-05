using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiVersionControll.Controllers.V1
{
    public class UserController : ApiControllerBase
    {
        // GET api/user
        public IEnumerable<string> Get()
        {
            return new string[] { "我是第1版的User数据", "value1" };
        }
    }
}
