using System;
using System.Runtime.Serialization;

namespace WindowsFormsSolution.Models
{
    [Serializable]
    internal class CantBeNullException : Exception
    {
        public CantBeNullException()
        {
        }

        public CantBeNullException(string message) : base(message)
        {
        }

        public CantBeNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CantBeNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}