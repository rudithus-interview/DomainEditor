using System;
using System.Runtime.Serialization;

namespace DomainEditor.Ports.Persistence.Exceptions
{
    [Serializable]
    public class GetEntityException : Exception
    {
        public GetEntityException() { }
        public GetEntityException(string message) : base(message) { }
        public GetEntityException(string message, Exception inner) : base(message, inner) { }
        protected GetEntityException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
