using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class CreateChannelReq : Protocol
    {
        public ulong GuildId { get; set; }
        public string ChannelName { get; set; }
    }

    [MessagePackObject]
    public class CreateChannelRes : ProtocolRes
    {
    }
}