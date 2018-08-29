using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories;
using Aledrogo.Repositories.Cache;
using Aledrogo.Utility;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aledrogo
{
    public class StartupConfiguration
    {
        public IServiceCollection ConfigureServices(IServiceCollection _services)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AledrogoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var configMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = configMapper.CreateMapper();

            _services.AddMvc();
            _services.AddDbContext<AledrogoContext>(options => options.UseSqlServer(connectionString));
            _services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AledrogoContext>();
            _services.AddSingleton(mapper);
            _services.AddScoped<IUserRepository, UserRepository>();
            _services.AddScoped<IProductRepository, ProductRespository>();
            _services.AddSingleton<ICategoryCache, CategoryCache>();           

            return _services;
        }

        public void InitializeDatabaseWithSeedData(IServiceProvider serviceProvider)
        {
            InitializeDatabaseWithSeedData(
                serviceProvider.GetRequiredService<AledrogoContext>(),
                serviceProvider.GetRequiredService<UserManager<User>>(),
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>()
                );
        }
        public void InitializeDatabaseWithSeedData(AledrogoContext context, 
            UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedData.Initialize(
                context,
                userManager,
                roleManager
                ).Wait();
        }
    }
}
