using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DogTransport.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DogTransport.Areas.Identity.Data;
using DogTransport.Models;

namespace DogTransport
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;

            HostingEnvironment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDefaultIdentity<AspNetUser>()
                .AddEntityFrameworkStores<Data.ApplicationDbContext>();

            if (HostingEnvironment.IsDevelopment())
            {
                services.AddDbContext<Data.ApplicationDbContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

                services.AddDbContext<Data.ApplicationDbContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            }
            else
            {
                services.AddDbContext<Data.ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AzureSQL")));

                services.AddDbContext<Data.ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AzureSQL")));
            }

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
