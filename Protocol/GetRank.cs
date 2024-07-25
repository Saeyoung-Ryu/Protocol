using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetRankReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class GetRankRes : ProtocolRes
    {
        [Key(2)] public List<MemberWinLoseInfo> MemberTotalRank { get; set; } // 전체멤버 정보 여가서불러오기
        [Key(3)] public List<MemberWinLoseInfo> MemberSupRank { get; set; }
        [Key(4)] public List<MemberWinLoseInfo> MemberAdcRank { get; set; }
        [Key(5)] public List<MemberWinLoseInfo> MemberMidRank { get; set; }
        [Key(6)] public List<MemberWinLoseInfo> MemberJgRank { get; set; }
        [Key(7)] public List<MemberWinLoseInfo> MemberTopRank { get; set; }
    }
}
    
