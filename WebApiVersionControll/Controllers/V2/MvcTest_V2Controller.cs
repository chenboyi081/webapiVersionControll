using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiVersionControll.Controllers.V2
{
    // MvcTest/Index
    public partial class MvcTestController : BaseController
    {
        public ActionResult Index()
        {
            return JsonDate(new { code = 1, message = "我是第二版的非登陆接口数据，二二二二二"});
        }
    }
}
