using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ValidatorGuard.CustomExceptions
{
    
    public class LessThenZeroValueException : Exception
    {
        public LessThenZeroValueException()
        {
        }

        public LessThenZeroValueException(string message) : base(message)
        {
        }

        public LessThenZeroValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LessThenZeroValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
