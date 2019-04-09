using System;
using System.Runtime.Serialization;

namespace ValidatorGuard.CustomExceptions
{

    public class StringIsNullOrWhiteSpaceException : Exception
    {
        public StringIsNullOrWhiteSpaceException()
        {
        }

        public StringIsNullOrWhiteSpaceException(string message) : base(message)
        {
        }

        public StringIsNullOrWhiteSpaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringIsNullOrWhiteSpaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}