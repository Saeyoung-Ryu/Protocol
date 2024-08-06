using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class ResetMemberRankReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long MasterSuid { get; set; } // 혹시나 마스터아닌사람이 수정할수있게될수도
    }

    [MessagePackObject]
    public class ResetMemberRankRes : ProtocolRes
    {
    }
}
    
