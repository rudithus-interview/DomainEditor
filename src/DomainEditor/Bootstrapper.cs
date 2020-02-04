using DomainEditor.UseCases;
using DomainEditor.UseCases.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DomainEditor
{
    public static class Bootstrapper
    {
        public static void AddUseCases(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICreateDomainUseCase, CreateDomainUseCase>();
            serviceCollection.AddTransient<IRetrieveDomainsUseCase, RetrieveDomainsUseCase>();
        }
    }
}
