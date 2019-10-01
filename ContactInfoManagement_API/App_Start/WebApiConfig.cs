﻿using ContactInfoManagement_API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ContactInfoManagement_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new CustomExceptionFilterAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
