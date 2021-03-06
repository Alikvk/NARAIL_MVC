﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NARAIL_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "About",
                url: "hakkimizda",
                defaults: new { controller = "Home", action = "About" }
            );
            routes.MapRoute(
                name: "Blog",
                url: "blog",
                defaults: new { controller = "Home", action = "Blog" }
            );
                routes.MapRoute(
                 name: "Contact",
                 url: "iletisim",
                 defaults: new { controller = "Home", action = "Contact" }
             );
            routes.MapRoute(
              name: "Project",
              url: "projelerimiz",
              defaults: new { controller = "Home", action = "Project" }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
