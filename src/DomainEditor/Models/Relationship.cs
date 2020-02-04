using System;
using System.Collections.Generic;
using DomainEditor.Models.Primitives;

namespace DomainEditor.Models
{
    public sealed class Relationship : Entity
    {
        public Relationship(
            DomainId domainId,
            EntityId entityId,
            EntityName entityName,
            Entity firstEntity,
            Entity secondEntity,
            IReadOnlyCollection<EntityAttribute> entityAttributes) : base(domainId, entityId, entityName, entityAttributes)
        {
            Entity = firstEntity ?? throw new ArgumentNullException(nameof(firstEntity));
            SecondEntity = secondEntity ?? throw new ArgumentNullException(nameof(secondEntity));
        }

        public Entity Entity { get; }
        public Entity SecondEntity { get; }
    }
}
