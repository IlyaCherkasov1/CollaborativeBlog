
using Azure.Storage.Blobs;
using CollaborativeBlog.Hubs;
using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CollaborativeBlog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR(options => { options.EnableDetailedErrors = true;});

            string connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connection)).AddIdentity<User, IdentityRole>()
              .AddEntityFrameworkStores<ApplicationContext>();

            services.AddTransient<IStringLocalizer, EFStringLocalizer>();
            services.AddSingleton<IStringLocalizerFactory>(new EFStringLocalizerFactory(connection));

            services.AddAuthentication().AddFacebook(config =>
            {
                config.AppId = Configuration["Authentication:Facebook:AppId"];
                config.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
    

            })
            .AddGoogle(config =>
            {
                config.ClientId = Configuration["Authentication:Google:ClientId"];
                config.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
        
            });

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Account/Login";
              //  config.AccessDeniedPath = "/Home/Index";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("User", builder =>
                {
                    builder.RequireClaim(ClaimTypes.Role, "User");
                });

                options.AddPolicy("Admin", builder =>
                {
                    builder.RequireAssertion(x => x.User.HasClaim(ClaimTypes.Role, "User")
                                                  || x.User.HasClaim(ClaimTypes.Role, "Admin"));
                });

            });

            var blobConnection = Configuration.GetValue<string>("BlobConnection");
            services.AddSingleton(x => new BlobServiceClient(blobConnection));
            services.AddSingleton<IBlobService, BlobService>();

            services.AddControllersWithViews(options => { options.SuppressAsyncSuffixInActionNames = false; })
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    factory.Create(null);
                }).AddViewLocalization();
                 
                

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("ru")
                };

                options.DefaultRequestCulture = new RequestCulture("ru");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }


            app.UseRequestLocalization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chat");
            });
        }
    }
}
