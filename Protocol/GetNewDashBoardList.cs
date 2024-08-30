using MessagePack;
using Protocol.Enum;

namespace Protocol
{
    [MessagePackObject]
    public class GetNewDashBoardListReq : Protocol
    {

    }

    [MessagePackObject]
    public class GetNewDashBoardListRes : ProtocolRes
    {
        [Key(2)] public List<string> DashBoardNames { get; set; }
        [Key(3)] public List<PremiumType> PremiumTypes { get; set; }
    }
}
    
