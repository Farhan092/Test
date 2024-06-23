﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(

                name: "test",
                url: "player/p",
                defaults: new { controller = "Sport", action = "Player" }


                );

            routes.MapRoute(

                name: "practice",
                url: "staff/s",
                defaults: new { controller = "Sport", action = "Staff" }


                );

            /*routes.MapRoute(

                name: "look",
                url: "stadium",
                defaults: new { controller = "Sport", action = "Stadium" }


                );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
