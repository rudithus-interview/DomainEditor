using System;
using System.Runtime.Serialization;

namespace DomainEditor.Ports.Persistence.Exceptions
{
    [Serializable]
    public class CreateDomainException : Exception
    {
        public CreateDomainException() { }
        public CreateDomainException(string message) : base(message) { }
        public CreateDomainException(string message, Exception inner) : base(message, inner) { }
        protected CreateDomainException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
