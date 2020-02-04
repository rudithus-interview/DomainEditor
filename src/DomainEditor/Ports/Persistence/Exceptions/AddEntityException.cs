using System;
using System.Runtime.Serialization;

namespace DomainEditor.Ports.Persistence.Exceptions
{

    [Serializable]
    public class AddEntityException : Exception
    {
        public AddEntityException() { }
        public AddEntityException(string message) : base(message) { }
        public AddEntityException(string message, Exception inner) : base(message, inner) { }
        protected AddEntityException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
