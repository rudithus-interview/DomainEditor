using DomainEditor.Ports.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace DomainEditor.Adapters.Persistence.InMemory
{
    public static class Bootstrapper
    {
        public static void AddInMemoryPersistence(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDomainRepository,DomainRepository>();
        }
    }
}
