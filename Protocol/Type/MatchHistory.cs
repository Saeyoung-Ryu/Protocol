using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class MatchHistory
{
    [Key(0)] public DateTime Time { get; set; }
    [Key(1)] public List<TeamMember> RedTeam { get; set; }
    [Key(2)] public List<TeamMember> BlueTeam { get; set; }
    [Key(3)] public string CreatorNickName { get; set; }
    [Key(4)] public List<Player> ManagerPlayerList { get; set; }
    [Key(5)] public TeamType WinTeam { get; set; }
}