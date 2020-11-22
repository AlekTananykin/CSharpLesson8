using System;
using System.Runtime.Serialization;

namespace Task4
{
    [Serializable]
    internal class ForeignWordBaseException : Exception
    {
        public ForeignWordBaseException()
        {
        }

        public ForeignWordBaseException(string message) : base(message)
        {
        }

        public ForeignWordBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ForeignWordBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}