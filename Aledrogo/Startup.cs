using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aledrogo
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly StartupConfiguration _startupConfiguration;

        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json");

            _config = builder.Build();

            _startupConfiguration = new StartupConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            _startupConfiguration.ConfigureServices(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;

                _startupConfiguration.InitializeDatabaseWithSeedData(serviceProvider);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseMvcWithDefaultRoute();
        }

        
    }
}
