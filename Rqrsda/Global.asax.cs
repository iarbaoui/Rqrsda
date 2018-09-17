using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Rqrsda.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Rqrsda
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new Initializer());

            // Use the camelcase format in the JSON objects that our application will return
            var formatters = GlobalConfiguration.Configuration.Formatters;

            var jsonFormatter = formatters.JsonFormatter;
            var jsonSettings = jsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
