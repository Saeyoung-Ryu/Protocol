using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class RiotPlayer
{
    [Key(0)] public string Puuid { get; set; }
    [Key(1)] public string NickName { get; set; }
    [Key(2)] public LineType LineType { get; set; }
}