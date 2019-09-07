using AutoMapper;
using FleetControl.Application.Commands.CreateCustomer;
using FleetControl.Application.Commands.Customers.CreateCustomer;
using FleetControl.Application.Commands.UpdateCustomer;
using FleetControl.Application.Infrastructure;
using FleetControl.Application.Infrastructure.AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using FleetControl.Common;
using FleetControl.Infrastructure;
using FleetControl.Persistence;
using FleetControl.Persistence.Identity;
using FleetControl.WebUI.Auth;
using FleetControl.WebUI.Filters;
using FleetControl.WebUI.Helpers;
using FleetControl.WebUI.Identity;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Reflection;
using System.Text;

namespace FleetControl.WebUI
{
    public class Startup
    {
        // https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; // todo: get this from somewhere secure
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));


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


            // Add DbContext using SQL Server Provider
            //services.AddDbContext<INorthwindDbContext, NorthwindDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("NorthwindDatabase")));
            services.AddDbContext<IFleetControlDbContext, FleetControlDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("FleetControlDatabase"), b => b.MigrationsAssembly("FleetControl.WebUI")));
            //options.UseSqlServer(Configuration.GetConnectionString("FleetControlDatabase"), builder => builder.UseRowNumberForPaging()));


            services.AddSingleton<IJwtFactory, JwtFactory>();

            // Add framework services.
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IDateTime, MachineDateTime>();
            

            // Add MediatR (this is a bit clunky but it gets the job done for now).
            // I am choosing a handler in each of the Query and Command assemblies so that I can tell Mediatr to monitor them
            services.AddMediatR(typeof(GetFleetCustomerDetail_QueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateFleetCustomer_Command).GetTypeInfo().Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

           

            services.AddTransient<SpragueUserManager<ApplicationUser>>();
            services.AddTransient<SpragueSignInManager<ApplicationUser>>();
            services.AddTransient<FleetControlDbContext>();


            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<FleetControlDbContext>()
                    .AddDefaultTokenProviders();




            services.AddScoped<Microsoft.AspNetCore.Identity.IUserClaimsPrincipalFactory<ApplicationUser>, AppClaimsPrincipalFactory>();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200",
                                        "http://localhost:4505")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        ;
                });
            });


            // Get options from app settings
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            });



            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            // api user claim policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.Strings.JwtClaims.ApiAccess, policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
                options.AddPolicy(Constants.Strings.JwtClaims.CardGrid, policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.CardGrid));
            });





            services.AddMvc();

            services
                .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UpdateCustomerCommandValidator>());


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


            // Register the Swagger Services
            services.AddSwaggerDocument();
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

            //app.UseSwaggerUi3();


            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/api";
                settings.DocumentPath = "/api/specification.json";
            });

            //app.UseSwagger

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthentication();

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
