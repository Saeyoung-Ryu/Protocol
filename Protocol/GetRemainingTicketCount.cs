using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class GetRemainingTicketCountReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        // [Key(2)] public long MasterSuid { get; set; }
    }

    [MessagePackObject]
    public class GetRemainingTicketCountRes : ProtocolRes
    {
        [Key(2)] public int RemainTicketCount { get; set; }
    }
}
    
