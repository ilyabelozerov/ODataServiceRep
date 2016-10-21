using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using ODataService.Models;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
