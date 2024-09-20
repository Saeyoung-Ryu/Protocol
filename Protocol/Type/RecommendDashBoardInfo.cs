using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class RecommendDashBoardInfo
{
    [Key(0)] public string DashBoardName { get; set; }
    [Key(1)] public string MasterName { get; set; }
    [Key(2)] public string Notification { get; set; }
    [Key(3)] public int MemberCount { get; set; }
    [Key(4)] public DateTime CreateTime { get; set; }
}