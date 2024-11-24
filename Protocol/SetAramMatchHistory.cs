using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class SetAramMatchHistoryReq : Protocol
    {
        [Key(1)] public int Seq { get; set; }
        [Key(2)] public int DashBoardSeq { get; set; }
        [Key(3)] public string CheckerName { get; set; }
        [Key(4)] public long CheckerSuid { get; set; }
        [Key(5)] public TeamType WinTeam { get; set; }
        [Key(6)] public bool IsEdit { get; set; }
        [Key(7)] public MatchHistoryInfo MatchHistoryInfo { get; set; }
    }

    [MessagePackObject]
    public class SetAramMatchHistoryRes : ProtocolRes
    {
        [Key(2)] public TeamType WinTeam { get; set; }
        [Key(3)] public string CheckerName { get; set; }
    }
}


