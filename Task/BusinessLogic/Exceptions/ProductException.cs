using System;

namespace BusinessLogic.Exceptions
{
    [Serializable]
    class ProductException : Exception
    {
        public ProductException(string message)
            : base(message)
        {
        }

        public ProductException()
        {
        }

        public ProductException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ProductException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
