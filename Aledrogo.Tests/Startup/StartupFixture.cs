using Microsoft.Extensions.DependencyInjection;

namespace Aledrogo.Tests
{
    public class StartupFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public StartupFixture()
        {
            Startup startup = new Startup();
            IServiceCollection services = startup.ConfigureServices(new ServiceCollection());

            ServiceProvider = services.BuildServiceProvider();
            startup.InitializeDatabaseWithSeedData(ServiceProvider);
        }
    }
}