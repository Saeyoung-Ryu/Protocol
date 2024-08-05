using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetDashBoardInfoReq : Protocol
    {
        [Key(1)] public string DashBoardName { get; set; }
        [Key(2)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class GetDashBoardInfoRes : ProtocolRes
    {
        [Key(2)] public DashBoardInfo DashBoardInfo { get; set; }
    }
}
    
