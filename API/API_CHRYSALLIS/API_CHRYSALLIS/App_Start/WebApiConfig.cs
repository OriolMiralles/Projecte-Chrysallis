using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_CHRYSALLIS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            //quitar trabajo con XML porque solo usamos JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //dar formato a json, eliminar referencias circulares 
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.None;
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
