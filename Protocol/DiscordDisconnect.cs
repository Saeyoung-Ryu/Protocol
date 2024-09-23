using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class DiscordDisconnectReq : Protocol
    {
        public long MasterSuid { get; set; }
        public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class DiscordDisconnectRes : ProtocolRes
    {
    }
}