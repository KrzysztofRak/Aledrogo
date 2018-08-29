using Aledrogo.Data;
using Aledrogo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aledrogo
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            new ServiceConfiguration(services).ConfigureServices();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;

                InitializeDatabaseWithSeedData(serviceProvider);
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

        public void InitializeDatabaseWithSeedData(IServiceProvider serviceProvider)
        {
            SeedData.Initialize(
                serviceProvider.GetRequiredService<AledrogoContext>(),
                serviceProvider.GetRequiredService<UserManager<User>>(),
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>()
                ).Wait();
        }
    }
}
