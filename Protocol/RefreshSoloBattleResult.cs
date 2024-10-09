using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class RefreshSoloBattleResultReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public int Seq { get; set; }
        [Key(3)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class RefreshSoloBattleResultRes : ProtocolRes
    {
        [Key(2)] public SoloRankMatchHistoryInfo SoloRankMatchHistoryInfo { get; set; }
    }
}
    
