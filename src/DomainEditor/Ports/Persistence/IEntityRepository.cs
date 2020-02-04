using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Models.Primitives;
using DomainEditor.Ports.Persistence.Exceptions;

namespace DomainEditor.Ports.Persistence
{
    /// <summary>
    /// Repository for retrieving and adding <see cref="Entity"/> 
    /// </summary>
    public interface IEntityRepository
    {
        /// <summary>
        /// Use for adding an <see cref="Entity"/> to a given <see cref="Domain"/> />
        /// </summary>
        /// <param name="domainId">Id of the <see cref="Domain"/> </param>
        /// <param name="name">Name of <see cref="Entity"/> </param>
        /// <param name="attributes">Attributes of the <see cref="Entity"/> </param>
        /// <param name="cancellationToken"></param>
        /// <returns>Persisted Entity</returns>
        /// <exception cref="AddEntityException"></exception>
        Task<Entity> AddAsync(DomainId domainId, EntityName name, IReadOnlyCollection<EntityAttribute> attributes, CancellationToken cancellationToken = default);

        /// <summary>
        /// Use for adding an <see cref="Entity"/> to a given <see cref="Domain"/> />
        /// </summary>
        /// <param name="domainId">Id of the <see cref="Domain"/> </param>
        /// <param name="name">Name of <see cref="Entity"/> </param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="AddEntityException"></exception>
        Task<Entity> AddAsync(DomainId domainId, EntityName name, CancellationToken cancellationToken = default);

        /// <summary>
        /// Use to get all entities
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Entity Collection</returns>
        /// <exception cref="GetEntityException"></exception>
        Task<IReadOnlyCollection<Entity>> GetAsync(DomainId domainId, CancellationToken cancellationToken = default);
    }
}
