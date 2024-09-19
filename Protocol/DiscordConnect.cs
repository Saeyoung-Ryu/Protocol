using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class DiscordConnectReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public string Code { get; set; }
        [Key(4)] public string GuildId { get; set; }
    }

    [MessagePackObject]
    public class DiscordConnectRes : ProtocolRes
    {
        
    }
}
    
