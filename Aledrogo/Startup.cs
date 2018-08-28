using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories;
using Aledrogo.Repositories.Cache;
using Aledrogo.Utility;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

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

        public Startup()
        {
            // Constructor for tests
            string testProjectPath = Directory.GetCurrentDirectory();
            string thisProjectPath = testProjectPath.Remove(testProjectPath.IndexOf(".Test"));

            var builder = new ConfigurationBuilder()
                .SetBasePath(thisProjectPath)
                .AddJsonFile("appsettings.json");

            _config = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = _config.GetConnectionString("DefaultConnection");

            var configMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = configMapper.CreateMapper();

            services.AddMvc();
            services.AddDbContext<AledrogoContext>(options => options.UseSqlServer(connectionString));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AledrogoContext>();
            services.AddSingleton(mapper);
            services.AddScoped<IUserRepository, UserRepository>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var context = serviceProvider.GetRequiredService<AledrogoContext>();
            var categoryCache = new CategoryCache(context);

            services.AddSingleton(categoryCache);
            services.AddSingleton(new ProductRespository(context, categoryCache));
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
