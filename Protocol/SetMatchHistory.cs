using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class SetMatchHistoryReq : Protocol
    {
        [Key(1)] public int Seq { get; set; }
        [Key(2)] public string? CheckerName { get; set; }
        [Key(3)] public TeamType WinTeam { get; set; }
    }

    [MessagePackObject]
    public class SetMatchHistoryRes : ProtocolRes
    {
        [Key(2)] public bool Success { get; set; }
    }
}


