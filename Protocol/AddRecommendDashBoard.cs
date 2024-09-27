using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class AddRecommendDashBoardReq : Protocol
    {
        public long Suid { get; set; }
        public List<int> DashBoardSeqList { get; set; }
    }

    [MessagePackObject]
    public class AddRecommendDashBoardRes : ProtocolRes
    {
        public List<RecommendDashBoardInfo> RecommendDashBoardInfos { get; set; }
    }
}