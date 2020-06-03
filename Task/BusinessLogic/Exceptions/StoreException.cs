using System;

namespace BusinessLogic.Exceptions
{
    [Serializable]
    public class StoreException : Exception
    {
        public StoreException(string message)
            : base(message)
        {
        }

        public StoreException()
        {
        }

        public StoreException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected StoreException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
