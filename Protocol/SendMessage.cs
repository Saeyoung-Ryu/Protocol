using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class SendMessageReq : Protocol
    {
        public ulong ChannelId { get; set; }
        public string Message { get; set; }
    }

    [MessagePackObject]
    public class SendMessageRes : ProtocolRes
    {
    }
}