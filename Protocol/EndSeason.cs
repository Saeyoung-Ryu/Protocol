using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class EndSeasonReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class EndSeasonRes : ProtocolRes
    {
        
    }
}
    
