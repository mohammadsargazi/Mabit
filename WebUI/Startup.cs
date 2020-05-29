using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebUI.Functionality;
using WebUI.LocalizationResources;


namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var cultures = new[]
            {
                new CultureInfo("ar"),
                new CultureInfo("en"),
                new CultureInfo("fa"),

            };
            services.AddControllersWithViews()
                .AddExpressLocalization<ExpressLocalizationResource, ViewLocalizationResource>(ops =>
            {
                ops.ResourcesPath = "LocalizationResources";
                ops.RequestLocalizationOptions = o =>
                {
                    o.SupportedCultures = cultures;
                    o.SupportedUICultures = cultures;
                    o.DefaultRequestCulture = new RequestCulture("en");
                };
            });
            //services.Configure<RequestLocalizationOptions>(options =>
            //{
            //    //...

            //    options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(context =>
            //    {
            //        //...
            //        var userLangs = context.Request.Headers["Accept-Language"].ToString();
            //        var firstLang = userLangs.Split(',').FirstOrDefault();
            //        var defaultLang = string.IsNullOrEmpty(firstLang) ? "en" : firstLang;
            //        return Task.FromResult(new ProviderCultureResult(defaultLang, defaultLang));
            //    }));
            //});
            services.AddScoped<CustomCookieAuthenticationEvents>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromDays(2);
                    options.LoginPath = new PathString("/Account/Login");
                    options.EventsType = typeof(CustomCookieAuthenticationEvents);
                });
            services.AddDistributedMemoryCache();
            
            //var persianCulture = new PersianCulture();
            //Thread.CurrentThread.CurrentCulture = persianCulture;
            //Thread.CurrentThread.CurrentUICulture = persianCulture;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    }
}
