using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using System.Web.Http;
using RealEstateManager.Models.Data;

namespace RealEstateManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Estate>("EstateApi");
            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
                     
        }
    }
}
