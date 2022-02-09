using System;
using System.Runtime.Serialization;

namespace Exercise_6
{
    [Serializable]
    internal class InvalidOcenkaException : Exception
    {
        private object predmet;

        public InvalidOcenkaException()
        {
        }

        public InvalidOcenkaException(object predmet)
        {
            this.predmet = predmet;
        }

        public InvalidOcenkaException(string message) : base(message)
        {
        }

        public InvalidOcenkaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOcenkaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}