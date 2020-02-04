using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DomainEditor.Models;
using DomainEditor.Models.Primitives;
using DomainEditor.Ports.Persistence;

namespace DomainEditor.Adapters.Persistence.InMemory
{

    /// <inheritdoc/>
    public class DomainRepository : IDomainRepository
    {
        private int _lastId = 1;
        private readonly List<Domain> _domains = new List<Domain>();

        public async Task<Domain> CreateAsync(DomainName domainName, CancellationToken cancellationToken = default)
        {
            return new Domain(GetNextDomainId(), domainName, Array.Empty<Entity>());
        }

        public async Task<IReadOnlyCollection<Domain>> GetAsync(CancellationToken cancellationToken = default)
        {
            return _domains.ToArray();
        }

        private DomainId GetNextDomainId() => new DomainId(_lastId++);
    }
}
