using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ProductApi",
                routeTemplate: "productapi",
                defaults: new { controller = "ProductApi", action = "Get" }
            );
        }
    }
}
