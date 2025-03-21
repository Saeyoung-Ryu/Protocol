using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class InsertMatchHistoryReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public string CreatorName { get; set; }
        [Key(3)] public long CreatorSuid { get; set; }
        [Key(4)] public List<TeamMember> BlueTeamMembers { get; set; }
        [Key(5)] public List<TeamMember> RedTeamMembers { get; set; }
        [Key(6)] public DateTime CurrentTime { get; set; }
        [Key(7)] public int WinPoint { get; set; }
        [Key(8)] public int LosePoint { get; set; }
    }

    [MessagePackObject]
    public class InsertMatchHistoryRes : ProtocolRes
    {
        [Key(2)] public List<MatchHistoryInfo> MatchHistoryList { get; set; }
    }
}
