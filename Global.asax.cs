using System;
using System.Net.Http.Headers;
using System.Web.Http;

namespace carbase
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			GlobalConfiguration.Configure(config =>
			{
				config.EnableCors();
				config.MapHttpAttributeRoutes();

				config.Routes.MapHttpRoute(
					name: "DefaultApi",
					routeTemplate: "{controller}/{id}", //default is API/{controller}/{id}
					defaults: new { id = RouteParameter.Optional }
				);

				config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
				
			});
		}

		protected void Session_Start(object sender, EventArgs e)
		{

		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}

}