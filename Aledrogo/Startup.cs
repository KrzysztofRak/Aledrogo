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
            services.AddScoped<IProductRepository, ProductRespository>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

<<<<<<< HEAD
            var context = serviceProvider.GetRequiredService<AledrogoContext>();
            services.AddSingleton(new CategoryCache(context));
=======
            services.AddScoped<ICategoryCache, CategoryCache>();
>>>>>>> bbe1c6bce5691d9a6bb5ae7774ae382f693d574d
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;
<<<<<<< HEAD
                SeedData.Initialize(serviceProvider).Wait();
=======
                SeedData.Initialize(
                    serviceProvider.GetRequiredService<AledrogoContext>(),
                    serviceProvider.GetRequiredService<UserManager<User>>(),
                    serviceProvider.GetRequiredService<RoleManager<IdentityRole>>()
                    ).Wait();
>>>>>>> bbe1c6bce5691d9a6bb5ae7774ae382f693d574d
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
