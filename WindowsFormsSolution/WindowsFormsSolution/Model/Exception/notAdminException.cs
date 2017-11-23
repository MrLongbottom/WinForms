using System;
using System.Runtime.Serialization;

namespace WinFromsSolution.Models
{
    [Serializable]
    internal class notAdminException : Exception
    {
        private User currentUser;

        public notAdminException()
        {
        }

        public notAdminException(User currentUser)
        {
            this.currentUser = currentUser;
        }

        public notAdminException(string message) : base(message)
        {
        }

        public notAdminException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected notAdminException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}