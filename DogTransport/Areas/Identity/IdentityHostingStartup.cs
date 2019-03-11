using System;
using DogTransport.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DogTransport.Areas.Identity.IdentityHostingStartup))]
namespace DogTransport.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DefaultConnection")));
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("ApplicationDbContextConnection")));



//                services.AddDefaultIdentity<IdentityUser>()
//                    .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}