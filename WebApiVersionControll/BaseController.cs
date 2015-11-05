using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiVersionControll
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 返回处理过时间的json
        /// 作者：hjj
        /// 时间：2105-8-12
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        protected ContentResult JsonDate(object Data)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            //后面要加 contentType:参数值"application/json" 否则只返回字符串非json格式了
            return Content(JsonConvert.SerializeObject(Data, Formatting.Indented, timeConverter), "application/json");
        }

    }
}