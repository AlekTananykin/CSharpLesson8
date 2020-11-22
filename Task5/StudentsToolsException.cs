using System;
using System.Runtime.Serialization;

namespace Task5
{
    [Serializable]
    internal class StudentsToolsException : Exception
    {
        public StudentsToolsException()
        {
        }

        public StudentsToolsException(string message) : base(message)
        {
        }

        public StudentsToolsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StudentsToolsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}