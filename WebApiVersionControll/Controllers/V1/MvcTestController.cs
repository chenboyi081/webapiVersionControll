using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiVersionControll.Controllers.V1
{
    // MvcTest/Index
    public class MvcTestController : BaseController
    {
        public ActionResult Index()
        {
            return JsonDate(new { code = 1, message = "我是第一版的非登陆接口数据，一一一一一一一"});
        }
    }
}
