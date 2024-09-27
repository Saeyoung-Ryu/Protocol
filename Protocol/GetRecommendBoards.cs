using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetRecommendBoardsReq : Protocol
    {
        public long Suid { get; set; }
    }

    [MessagePackObject]
    public class GetRecommendBoardsRes : ProtocolRes
    {
        [Key(2)] public List<RecommendDashBoardInfo> RecommendDashBoardInfos { get; set; }
        [Key(3)] public List<DashBoardInfoLobby> MyCreatedDashBoards { get; set; }
    }
}
    
