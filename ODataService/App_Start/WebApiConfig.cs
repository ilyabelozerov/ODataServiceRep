using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using ODataService.Models;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.Http.Cors;

namespace ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Включить кросс-доменные запросы
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);

            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();

            // Подключаем обработчик Batch-запросов
            ODataBatchHandler odataBatchHandler =
                new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer);
            odataBatchHandler.MessageQuotas.MaxOperationsPerChangeset = 10;
            odataBatchHandler.MessageQuotas.MaxPartsPerBatch = 10;

            // Конфигурация и службы веб-API
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.Namespace = "belozerov";
            builder.ContainerName = "SqliteContext";
            builder.EntitySet<Product>("Products");

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel(),
                batchHandler: odataBatchHandler
                );
        }
    }
}
