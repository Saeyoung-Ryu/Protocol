using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class DashBoardInfo
{
    [Key(0)] public int DashBoardSeq { get; set; }
    [Key(1)] public string Name { get; set; }
    [Key(2)] public DateTime CreateTime { get; set; }
    [Key(3)] public string MasterName { get; set; }
    [Key(4)] public bool IsManager { get; set; }
    
    [Key(5)] public List<MemberWinLoseInfo> MemberTotalRank { get; set; } // 전체멤버 정보 여가서불러오기
    [Key(6)] public List<MemberWinLoseInfo> MemberSupRank { get; set; }
    [Key(7)] public List<MemberWinLoseInfo> MemberAdcRank { get; set; }
    [Key(8)] public List<MemberWinLoseInfo> MemberMidRank { get; set; }
    [Key(9)] public List<MemberWinLoseInfo> MemberJgRank { get; set; }
    [Key(10)] public List<MemberWinLoseInfo> MemberTopRank { get; set; }
    [Key(11)] public int Point { get; set; }
    [Key(12)] public string Notification { get; set; }
    [Key(13)] public string NotificationNext { get; set; }
    [Key(14)] public int TicketUsed { get; set; }
    [Key(15)] public int MaxTicket { get; set; }
    [Key(16)] public int MaxMember { get; set; }
    // [Key(16)] public long MasterSuid { get; set; }
    [Key(17)] public List<MatchHistoryInfo> MatchHistoryInfos { get; set; }
    
    [Key(18)] public int DashBoardLikeCount { get; set; }
    [Key(19)] public PremiumType MasterPremiumType { get; set; }
    [Key(20)] public string Region { get; set; }
}