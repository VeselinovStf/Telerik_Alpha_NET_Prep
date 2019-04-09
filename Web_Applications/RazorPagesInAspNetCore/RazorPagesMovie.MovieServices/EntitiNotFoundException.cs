using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RazorPagesMovie.MovieServices
{
    public class EntitiNotFoundException : Exception
    {
        public EntitiNotFoundException()
        {
        }

        public EntitiNotFoundException(string message) : base(message)
        {
        }

        public EntitiNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntitiNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
