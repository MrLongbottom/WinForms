using System;
using System.Runtime.Serialization;

namespace WindowsFormsSolution.Models
{
    [Serializable]
    internal class DoNotContainElementException : Exception
    {
        public DoNotContainElementException()
        {
        }

        public DoNotContainElementException(string message) : base(message)
        {
        }

        public DoNotContainElementException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DoNotContainElementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}