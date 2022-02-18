using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class Range : Exception
    {
        public Range()
        {
        }

        public Range(string message) : base(message)
        {
        }

        public Range(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Range(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}