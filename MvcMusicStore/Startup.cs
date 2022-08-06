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
using MvcMusicStore.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcMusicStore.Models;
//namespaces required for localization
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;

namespace MvcMusicStore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //... changed to false so cookies and session variables persist
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            //...database service to inject the configuration for the database
            services.AddDbContext<MvcMusicStoreContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MvcMusicStoreConnection")));

            //...session add support for session variables
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //...localization: add localization services to provide dependency injection in controllers
            // & @inject in views. Also states default folder for resource files
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            //...localization: store configured IStringLocalizer for use in Models
            // you can either use a dummy "Shared Resources" controller or the controller
            // written to allow a user to delect a language.
            Controllers.SharedResources.StringLocalizer = 
                services.BuildServiceProvider().GetService<IStringLocalizer<Controllers.SharedResources>>();
            Controllers.LocalizationController.StringLocalizer = 
                services.BuildServiceProvider().GetService<IStringLocalizer<Controllers.LocalizationController>>();


            //...localization: add localizing support to AddMvc() for views and ValidationAttributes in models
            services.AddMvc()                
                // support for View Localizers: Resources/Views.Artist.Index.zh-CN.resx
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                // support for localizing strings in data annotations (e.g. validation messages)     
                .AddDataAnnotationsLocalization();

            //...localization: Configure the default & supported Cultures/UICultures
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                                        {
                                            new CultureInfo("en-US"),
                                            new CultureInfo("de-DE"),
                                            new CultureInfo("zh-CN")
                                        };
                // State the default culture for your application – used if a culture cannot be found
                options.DefaultRequestCulture = new RequestCulture("en-US");

                // State the cultures your application supports for formatting numbers, dates, etc. 
                options.SupportedCultures = supportedCultures;

                // State the UI cultures (languages) for which the app has localized resources (translated phrases)
                options.SupportedUICultures = supportedCultures;
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure 
        // the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //...session allow site to use session variables
            app.UseSession();
            app.UseAuthentication();

            //...localization: Implement localization services on this site
            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);
            //...localization: or, because of configuration in ConfigureServices, 
            // do we just need:
            //app.UseRequestLocalization();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
