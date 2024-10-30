using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class SetDashBoardColorReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public int Color { get; set; }
    }

    [MessagePackObject]
    public class SetDashBoardColorRes : ProtocolRes
    {
        
    }
}
    
