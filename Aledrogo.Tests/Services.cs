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

namespace Aledrogo.Tests
{
    public static class Service
    {
        private static IServiceProvider _provider;

        public static IServiceProvider Provider
        {
            get
            {
                if (_provider == null)
                    ConfigureServices();
                return _provider;
            }
            set
            {
                _provider = value;
            }
        }

        private static void ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=AledrogoDB;Trusted_Connection=True;MultipleActiveResultSets=true";

            var configMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = configMapper.CreateMapper();

            services.AddMvc();
            services.AddDbContext<AledrogoContext>(options => options.UseSqlServer(connectionString));
            services.AddSingleton(mapper);
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AledrogoContext>();
            services.AddScoped<IUserRepository, UserRepository>();

            Provider = services.BuildServiceProvider();

            var context = Provider.GetRequiredService<AledrogoContext>();
            var categoryCache = new CategoryCache(context);

            services.AddSingleton(new ProductRespository(context, categoryCache));
            services.AddSingleton(categoryCache);

            Provider = services.BuildServiceProvider();
        }
    }
}
