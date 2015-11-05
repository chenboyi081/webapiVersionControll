using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiVersionControll
{
    public class ApiControllerBase : ApiController
    {
        protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
        {
            //string controllerValue = SelectTools.GetRouteVariable(controllerContext.RouteData, "controller");
            //string controllerValue = SelectTools.GetRouteVariable(controllerContext.RouteData, "controller");
        }
    }
}