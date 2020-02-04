using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;

namespace DomainEditor.UseCases.Abstractions
{
    public interface IRetrieveDomainsUseCase
    {
        Task<IEnumerable<Domain>> RetrieveAllAsync(CancellationToken cancellationToken = default);
    }
}