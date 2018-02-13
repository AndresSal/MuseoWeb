using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MuseoVirtual
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Menu", action = "Inicio", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Mapa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Map", action = "Show_Map", id = UrlParameter.Optional }
            );
        }
    }
}
