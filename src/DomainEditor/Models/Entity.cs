using System;
using System.Collections.Generic;
using DomainEditor.Models.Primitives;

namespace DomainEditor.Models
{
    public class Entity
    {
        public Entity(
            DomainId domainId,
            EntityId entityId,
            EntityName entityName,
            IReadOnlyCollection<EntityAttribute> entityAttributes)
        {
            DomainId = domainId ?? throw new ArgumentNullException(nameof(domainId));
            Id = entityId ?? throw new ArgumentNullException(nameof(entityId));
            Name = entityName ?? throw new ArgumentNullException(nameof(EntityName));
            EntityAttributes = entityAttributes ?? throw new ArgumentNullException(nameof(EntityAttribute));
        }

        public DomainId DomainId { get; }
        public EntityId Id { get; }
        public EntityName Name { get; }
        public IReadOnlyCollection<EntityAttribute> EntityAttributes { get; }
    }
}