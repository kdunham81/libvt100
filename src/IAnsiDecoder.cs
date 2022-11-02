namespace libvt100
{
    using System.Text;

    public interface IAnsiDecoder : IDecoder
    {
        void Subscribe(IAnsiDecoderClient _client);
        void UnSubscribe(IAnsiDecoderClient _client);
    }
}