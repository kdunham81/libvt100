namespace libvt100
{
    using System.Runtime.Serialization;

    [Serializable]
    public class InvalidByteException : Exception
    {
        protected byte m_byte;

        public byte Byte
        {
            get
            {
                return m_byte;
            }
        }

        public InvalidByteException(byte _byte, string _message)
           : base(_message)
        {
            m_byte = _byte;
        }

        protected InvalidByteException(SerializationInfo info,
                                        StreamingContext context)
           : base(info, context)
        {
            info.AddValue("Byte", m_byte);
        }
    }
}