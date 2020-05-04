using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthPromotion.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthPromotion
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
     
            services.AddScoped<IPostRepository, MockPostRepository>();
            services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews(o => {
                o.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

            app.UseRouting();
        }
    }
}
