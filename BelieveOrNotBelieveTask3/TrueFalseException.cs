using System;
using System.Runtime.Serialization;

namespace BelieveOrNotBelieveTask3
{
    [Serializable]
    internal class TrueFalseException : Exception
    {
        public TrueFalseException()
        {
        }

        public TrueFalseException(string message) : base(message)
        {
        }

        public TrueFalseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TrueFalseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}