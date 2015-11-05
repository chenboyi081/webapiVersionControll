using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiVersionControll
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "V2",
              url: "v2/{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new string[] { "WebApiVersionControll.Controllers.V2" }
          );

            routes.MapRoute(
              name: "V1",
              url: "v1/{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new string[] { "WebApiVersionControll.Controllers.V1" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "WebApiVersionControll.Controllers.V1" }
            );

          
        }
    }
}