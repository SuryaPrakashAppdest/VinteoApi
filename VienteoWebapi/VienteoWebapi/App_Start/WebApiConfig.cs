﻿using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace VienteoWebapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                 routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
        }
        public class PreflightRequestsHandler : DelegatingHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (request.Headers.Contains("Origin") && request.Method.Method.Equals("OPTIONS"))
                {
                    var response = new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
                    // Define and add values to variables: origins, headers, methods (can be global)               
                    response.Headers.Add("Access-Control-Allow-Headers", "accept, content-type");

                    var tsc = new TaskCompletionSource<HttpResponseMessage>();
                    tsc.SetResult(response);
                    return tsc.Task;
                }
                return base.SendAsync(request, cancellationToken);
            }

        }
    }
}
