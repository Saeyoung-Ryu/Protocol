using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class DeleteMatchHistoryReq : Protocol
    {
        [Key(1)] public int Seq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class DeleteMatchHistoryRes : ProtocolRes
    {
        
    }
}
    
