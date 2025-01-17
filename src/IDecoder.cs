﻿namespace libvt100
{
    using System.Text;

    public delegate void DecoderOutputDelegate(IDecoder _decoder, byte[] _output);

    public interface IDecoder : IDisposable
    {
        Encoding? Encoding { get; set; }

        /// <summary>
        /// Tell decoder to process the given data.
        /// 
        /// If an invalid byte is passed InvalidByteException or one
        /// of the its sub-classes is thrown. The decoder will try its
        /// best to survive any invalid data and should still be able
        /// to process data after an exception is thrown.
        /// </summary>
        void Input(byte[] _data);

        event DecoderOutputDelegate Output;

        bool KeyPressed(ConsoleModifiers _modifiers, ConsoleKey _key);
        void CharacterTyped(char _character);
    }
}