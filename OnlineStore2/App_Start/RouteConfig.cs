using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineStore2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            //    );

            // What I found out is for now to fix all controller's action methods (e.g. Motorcycles/Create, the with HTTPPOST attrubute) it is better to have an explicit map routing, otherwise I get errors.    
            routes.MapRoute(
                name: "Create",
                url: "Motorcycles/Create",
                defaults: new { controller = "Motorcycles", action = "Create" });

        }
    }
}
