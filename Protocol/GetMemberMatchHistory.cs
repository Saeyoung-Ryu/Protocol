using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetMemberMatchHistoryReq : Protocol
    {
        public string DashBoardName { get; set; }
        public int MemberSeq { get; set; }
    }

    [MessagePackObject]
    public class GetMemberMatchHistoryRes : ProtocolRes
    {
        public string Discord { get; set; }
        public string MemberName { get; set; }
        public string MemberTag { get; set; }
        
        public int TotalWinCount { get; set; }
        public int TotalLoseCount { get; set; }
        public int TopWinCount { get; set; }
        public int TopLoseCount { get; set; }
        public int JungleWinCount { get; set; }
        public int JungleLoseCount { get; set; }
        public int MidWinCount { get; set; }
        public int MidLoseCount { get; set; }
        public int AdcWinCount { get; set; }
        public int AdcLoseCount { get; set; }
        public int SupportWinCount { get; set; }
        public int SupportLoseCount { get; set; }
        public int TotalPoint { get; set; }
        
        public List<MatchHistoryInfo> MatchHistoryInfos { get; set; }
        
        public SummonerInfo SummonerInfo { get; set; }
    }
}