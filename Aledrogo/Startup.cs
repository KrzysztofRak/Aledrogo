using Aledrogo.Data;
using Aledrogo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            string connectionString = _config.GetConnectionString("DefaultConnection");

            services.AddDbContext<AledrogoContext>(options => options.UseSqlServer(connectionString));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AledrogoContext>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;
                SeedData.Initialize(serviceProvider);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
