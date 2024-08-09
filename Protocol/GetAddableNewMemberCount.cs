using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class GetAddableNewMemberCountReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        // [Key(2)] public long MasterSuid { get; set; }
    }

    [MessagePackObject]
    public class GetAddableNewMemberCountRes : ProtocolRes
    {
        [Key(2)] public int Count { get; set; }
    }
}
    
