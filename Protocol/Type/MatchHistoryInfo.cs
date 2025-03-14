using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class MatchHistoryInfo
{
    [Key(0)] public DateTime Time { get; set; }
    [Key(1)] public List<TeamMember> RedTeam { get; set; }
    [Key(2)] public List<TeamMember> BlueTeam { get; set; }
    [Key(3)] public string CreatorNickName { get; set; }
    [Key(4)] public string? CheckerNickName { get; set; }
    [Key(5)] public TeamType WinTeam { get; set; }
    [Key(6)] public int Seq { get; set; }
    [Key(7)] public int WinPoint { get; set; }
    [Key(8)] public int LosePoint { get; set; }
}