using System;
using System.Runtime.Serialization;

namespace ValidatorGuard.CustomExceptions
{

    public class DateTimeIsOldException : Exception
    {
        public DateTimeIsOldException()
        {
        }

        public DateTimeIsOldException(string message) : base(message)
        {
        }

        public DateTimeIsOldException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateTimeIsOldException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}