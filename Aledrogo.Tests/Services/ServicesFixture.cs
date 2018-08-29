
using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories;
using Aledrogo.Repositories.Cache;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aledrogo.Tests
{
    public class ServicesFixture
    {
        public AledrogoContext Context { get; private set; }
        public UserManager<User> UserManager { get; private set; }
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public ICategoryCache CategoryCache { get; private set; }

        private readonly IServiceProvider _provider;

        public ServicesFixture()
        {
            var services = new ServiceConfiguration(new ServiceCollection()).ConfigureServices();
            _provider = services.BuildServiceProvider();

            Context = _provider.GetRequiredService<AledrogoContext>();
            UserManager = _provider.GetRequiredService<UserManager<User>>();
            RoleManager = _provider.GetRequiredService<RoleManager<IdentityRole>>();
            UserRepository = _provider.GetRequiredService<IUserRepository>();
            ProductRepository = _provider.GetRequiredService<IProductRepository>();
            CategoryCache = _provider.GetRequiredService<ICategoryCache>();
        }
    }
}