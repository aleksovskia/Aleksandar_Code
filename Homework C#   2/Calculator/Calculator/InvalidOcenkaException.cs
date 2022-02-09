using System;
using System.Runtime.Serialization;

namespace Calculator
{
    [Serializable]
    internal class InvalidOcenkaException : Exception
    {
        private int prvBorj;

        public InvalidOcenkaException()
        {
        }

        public InvalidOcenkaException(int prvBorj)
        {
            this.prvBorj = prvBorj;
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