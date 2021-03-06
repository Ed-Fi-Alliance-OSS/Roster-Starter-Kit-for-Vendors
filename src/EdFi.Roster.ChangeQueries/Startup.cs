using System;
using System.Linq;
using EdFi.Common;
using EdFi.Roster.ChangeQueries.Services;
using EdFi.Roster.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EdFi.Roster.ChangeQueries
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
            services.AddControllersWithViews();
            services.AddScoped<BaseDbContext>(x =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<ChangeQueryDbContext>();
                optionsBuilder.UseSqlite(Configuration.GetConnectionString("ResourceData"));
                return new ChangeQueryDbContext(optionsBuilder.Options);
            });
            RegisterServices(services, typeof(IMarkerForEdFiResourceServices));
            RegisterServices(services, typeof(IMarkerForCommonServices));
            services.AddTransient<IConfigurationService, ChangeQueriesConfigurationService>();
        }

        private static void RegisterServices(IServiceCollection services, Type servicesType)
        {
            foreach (var type in servicesType.Assembly.GetTypes())
            {
                if (!type.IsClass || type.IsAbstract || !type.IsPublic && !type.IsNestedPublic) continue;
                var concreteClass = type;

                var interfaces = concreteClass.GetInterfaces().ToArray();

                if (interfaces.Length == 1)
                {
                    var serviceType = interfaces.Single();

                    if (serviceType.FullName == $"{concreteClass.Namespace}.I{concreteClass.Name}")
                        services.AddTransient(serviceType, concreteClass);
                }
                else if (interfaces.Length == 0)
                {
                    if (concreteClass.Name.EndsWith("Service"))
                        services.AddTransient(concreteClass);
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BaseDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Perform automatic db migrations
            dbContext.Database.Migrate();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
