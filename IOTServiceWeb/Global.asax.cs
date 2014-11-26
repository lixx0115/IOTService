// ***********************************************************************
// <copyright file="Global.asax.cs" company="">
//     Copyright (c)  Microsoft Corporation. All rights reserved.
// </copyright>
// ***********************************************************************

namespace IOTServiceWeb
{
    using System.Net.Http.Formatting;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using IOTServiceWeb.Areas.HelpPage;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// The web api application.
    /// </summary>
    public class WebApiApplication : HttpApplication
    {
        #region Methods

        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Replace the default JsonFormatter with our custom one
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.SetDocumentationProvider(
                new XmlDocumentationProvider(HttpContext.Current.Server.MapPath("~/App_Data/XmlDocument.xml")));
            JsonMediaTypeFormatter json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings = new JsonSerializerSettings
                                          {
                                              ContractResolver =
                                                  new CamelCasePropertyNamesContractResolver()
                                          };
        }

        #endregion
    }
}