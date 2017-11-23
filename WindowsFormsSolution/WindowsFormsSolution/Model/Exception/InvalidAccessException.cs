using System;
using System.Runtime.Serialization;

namespace WinFromsSolution.Models
{
    [Serializable]
    internal class InvalidAccessException : Exception
    {
        public InvalidAccessException()
        {
        }

        public InvalidAccessException(string message) : base(message)
        {
        }

        public InvalidAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}