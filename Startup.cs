
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }
  public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
       loggerFactory.AddConsole();

       //Use Static Files
        app.UseStaticFiles();

        app.UseStatusCodePagesWithRedirects("/{0}.html");
        
          app.Map("/devcon",mvcapp=>{
             mvcapp.UseMvcWithDefaultRoute();
         });

         app.Run(c=>c.Response.WriteAsync("Hello World from Startup file!"));
    }
}