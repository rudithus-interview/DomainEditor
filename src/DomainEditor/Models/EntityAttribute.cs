using System;

namespace DomainEditor.Models
{
    public class EntityAttribute
    {
        public EntityAttribute(AttributeType attributeType, AttributeName attributeName)
        {
            AttributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
        }

        public AttributeType AttributeType { get; }
        public AttributeName AttributeName { get; }
    }
}