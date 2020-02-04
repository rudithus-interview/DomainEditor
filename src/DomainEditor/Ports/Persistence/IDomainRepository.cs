using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Models.Primitives;
using DomainEditor.Ports.Persistence.Exceptions;

namespace DomainEditor.Ports.Persistence
{
    /// <summary>
    /// Repository for storing/retrieving domains
    /// </summary>
    public interface IDomainRepository
    {
        /// <summary>
        /// Returns all the domains in the repository
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Read only collection of <see cref="Domain"/> </returns>
        /// <exception cref="GetDomainException"/>
        Task<IReadOnlyCollection<Domain>> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Use for persisting an <see cref="Entity"/> If persist is successful, <see cref="Domain"/> will be returned
        /// </summary>
        /// <param name="domainName">Name of the domain</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Persisted Domain</returns>
        /// <exception cref="CreateDomainException"/>
        Task<Domain> CreateAsync(DomainName domainName, CancellationToken cancellationToken = default);
    }
}
