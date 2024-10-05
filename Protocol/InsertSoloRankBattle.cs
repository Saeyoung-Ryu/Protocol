using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class InsertSoloRankBattleReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public List<List<Member>> TeamMemberList { get; set; }
        [Key(4)] public int RemainTime { get; set; }
        [Key(5)] public int GameCount { get; set; }
    }

    [MessagePackObject]
    public class InsertSoloRankBattleRes : ProtocolRes
    {
        
    }
}
    
