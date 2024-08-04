using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class DismissDashBoardReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class DismissDashBoardRes : ProtocolRes
    {
    }
}
    
