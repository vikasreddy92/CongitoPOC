using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BlazorClient.Areas.Identity.IdentityHostingStartup))]
namespace BlazorClient.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}