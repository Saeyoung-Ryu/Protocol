using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class MemberWinLoseInfo
{
    [Key(0)] public string Name { get; set; }
    [Key(1)] public int WinCount { get; set; }
    [Key(2)] public int LoseCount { get; set; }
}