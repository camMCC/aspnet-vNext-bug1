using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Routing;

namespace WebApplication1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940

            app.UseServices(services => {
                services.AddMvc();
            });

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "app",
                    template: "{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
