using Aledrogo.Repositories;
using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace Aledrogo.Tests
{
    public class ServicesFixture
    {
        public ProductRespository ProductRepository { get; private set; }
        public CategoryCache CategoryCache { get; private set; }

        private readonly IServiceProvider _provider;
        private readonly Startup _startup;

        private static ServicesFixture Instance { get; set; } = null;

        public ServicesFixture()
        {
            if (Instance != null)
                Debug.WriteLine("hahahaha");
            else
                Instance = this;

            Debug.WriteLine("Znowu");
            _startup = new Startup();
            _provider = GetProvider();

            _startup.InitializeDatabaseWithSeedData(_provider);
            _startup.LoadCache(_provider);

            ProductRepository = _provider.GetRequiredService<ProductRespository>();
            CategoryCache = _provider.GetRequiredService<CategoryCache>();
        }

        private IServiceProvider GetProvider()
        {
            IServiceCollection services = new ServiceCollection();
            _startup.ConfigureServices(services);
            return services.BuildServiceProvider();
        }
    }
}
