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
    public class ServiceConfiguration
    {
        private readonly IServiceCollection _services;

        public ServiceConfiguration(IServiceCollection services)
        {
            _services = services;
        }

        public IServiceCollection ConfigureServices()
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
    }
}
