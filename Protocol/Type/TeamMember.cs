using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class TeamMember
{
    [Key(0)] public int MemberSeq { get; set; }
    [Key(1)] public string MemberName { get; set; }
    [Key(2)] public LineType LineType { get; set; }
    public string? Tag { get; set; }
}