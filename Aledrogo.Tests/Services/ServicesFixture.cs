
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
        public IUserRepository UserRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public ICategoryCache CategoryCache { get; private set; }

        private readonly StartupConfiguration _startupConfiguration;

        private readonly IServiceProvider _provider;

        public ServicesFixture()
        {
            _startupConfiguration = new StartupConfiguration();
            var services = _startupConfiguration.ConfigureServices(new ServiceCollection());
            _provider = services.BuildServiceProvider();

            _startupConfiguration.InitializeDatabaseWithSeedData(_provider);

            UserRepository = _provider.GetRequiredService<IUserRepository>();
            ProductRepository = _provider.GetRequiredService<IProductRepository>();
            CategoryCache = _provider.GetRequiredService<ICategoryCache>();
        }
    }
}