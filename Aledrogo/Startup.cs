using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories.Cache;
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
            new ConfigureServices(services).Configure();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;

                InitializeDatabaseWithSeedData(serviceProvider);
                LoadCache(serviceProvider);
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

        public void LoadCache(IServiceProvider serviceProvider)
        {
            var categoryCache = serviceProvider.GetRequiredService<CategoryCache>();
            categoryCache.LoadFromDatabase();
        }
    }
}
