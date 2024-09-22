using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetRecommendBoardsReq : Protocol
    {

    }

    [MessagePackObject]
    public class GetRecommendBoardsRes : ProtocolRes
    {
        [Key(2)] public List<RecommendDashBoardInfo> RecommendDashBoardInfos { get; set; }
    }
}
    
