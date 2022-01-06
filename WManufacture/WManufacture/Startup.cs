using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace WManufacture
{
    public class Startup
    {
        private readonly IWebHostEnvironment _environment;

        private readonly IConfiguration _configuration;

        private readonly string _jsClient;

        public Startup(
            IWebHostEnvironment environment,
            IConfiguration configuration)
        {
            _environment = environment;

            _configuration = configuration;

            _jsClient = "WManufactureClient";
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            services.AddSpaStaticFiles(configuration => configuration.RootPath = $"{_jsClient}/dist");
        }

        public void Configure(IApplicationBuilder app)
        {
            if (_environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCors();

            app.UseRouting();

            app
                .UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute())
                .UseSpa(spa =>
                {
                    spa.Options.SourcePath = $"{_jsClient}";

                    if (_environment.IsDevelopment())
                    {
                        spa.UseAngularCliServer(npmScript: "start");
                    }
                });
        }
    }
}
