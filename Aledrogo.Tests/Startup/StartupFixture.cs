using Microsoft.Extensions.DependencyInjection;

namespace Aledrogo.Tests
{
    public class StartupFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public StartupFixture()
        {
            var startup = new Startup();
            var services = new ServiceCollection();

            startup.ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            startup.InitializeDatabaseWithSeedData(ServiceProvider);
        }
    }
}