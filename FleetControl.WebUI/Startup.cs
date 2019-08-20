using AutoMapper;
using FleetControl.Application.Commands.CreateCustomer;
using FleetControl.Application.Infrastructure;
using FleetControl.Application.Infrastructure.AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using FleetControl.Common;
using FleetControl.Infrastructure;
using FleetControl.Persistence;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FleetControl.WebUI
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
            // Add AutoMapper
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });


            // Add framework services.
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IDateTime, MachineDateTime>();

            // Add MediatR (this is a bit clunky but it gets the job done for now).
            // I am choosing a handler in each of the Query and Command assemblies so that I can tell Mediatr to monitor them
            services.AddMediatR(typeof(GetFleetCustomerDetail_QueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateFleetCustomerCommand).GetTypeInfo().Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            // Add DbContext using SQL Server Provider
            //services.AddDbContext<INorthwindDbContext, NorthwindDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("NorthwindDatabase")));

            services.AddDbContext<IFleetControlDbContext, FleetControlDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FleetControlDatabase"), builder => builder.UseRowNumberForPaging()));

            services.AddMvc();

            //services
            //    .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
            //    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
            //    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateNorthwindCustomerCommandValidator>());


            // This allows for the dependency injection of the config file. It is injected as type IOptions<ConnectionStringConfig>, and referenced with *.Value.NorthwindDatabase
            services.Configure<ConnectionStringConfig>(this.Configuration.GetSection("ConnectionStrings"));
           

            // Customise default API behavour
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
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
            app.UseSpaStaticFiles();

            //app.UseSwaggerUi3(settings =>
            //{
            //    settings.Path = "/api";
            //    settings.DocumentPath = "/api/specification.json";
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
                }
            });
        }

        public void CreateMapping()
        {
            
        }
    }
}
