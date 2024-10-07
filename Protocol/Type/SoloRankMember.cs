using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class SoloRankMember
{
    [Key(0)] public int MemberSeq { get; set; }
    [Key(1)] public string MemberName { get; set; }
    [Key(2)] public int WinCount { get; set; }
    [Key(3)] public int LoseCount { get; set; }
}