using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>()
                    //     .Configure(app=>{
                    //     app.Run(c=>c.Response.WriteAsync("Hello World from new dotnet core!"));
                    // })
                    .Build();
            host.Run();
            
    }
}
