using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_MVCProjectStructure
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // to enable attribute based routing

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // pattern
                defaults: new
                {
                    controller = "Student",
                    action = "Create",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "SecondRoute",
                url: "{controller}/{action}/{id}/{name}"
                );
        }
    }
}
