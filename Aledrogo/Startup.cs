using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories;
using Aledrogo.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
            var configMapper = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = configMapper.CreateMapper();

            services.AddMvc();
            services.AddDbContext<AledrogoContext>(options => options.UseSqlServer(connectionString));
            services.AddSingleton(mapper);
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AledrogoContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            
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
            else
            {
                app.UseExceptionHandler();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
