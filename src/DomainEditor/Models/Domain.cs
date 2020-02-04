using System;
using System.Collections.Generic;
using DomainEditor.Models.Primitives;

namespace DomainEditor.Models
{
    public class Domain
    {
        public Domain(DomainId domainId, DomainName domainName, IReadOnlyCollection<Entity> domainEntities)
        {
            DomainId = domainId ?? throw new ArgumentNullException(nameof(domainId));
            DomainName = domainName ?? throw new ArgumentNullException(nameof(domainName));
            DomainEntities = domainEntities ?? throw new ArgumentNullException(nameof(domainEntities));
        }

        public DomainName DomainName { get; }
        public DomainId DomainId { get; }
        public IReadOnlyCollection<Entity> DomainEntities { get; }
    }
}
