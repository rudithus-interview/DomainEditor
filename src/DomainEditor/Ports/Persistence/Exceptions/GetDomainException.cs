using System;
using System.Runtime.Serialization;

namespace DomainEditor.Ports.Persistence.Exceptions
{
    [Serializable]
    public class GetDomainException : Exception
    {
        public GetDomainException() { }
        public GetDomainException(string message) : base(message) { }
        public GetDomainException(string message, Exception inner) : base(message, inner) { }
        protected GetDomainException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
