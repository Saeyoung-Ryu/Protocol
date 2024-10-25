using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class AddDashBoardMemberReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public string NewMemberName { get; set; }
        [Key(3)] public string NewMemberTag { get; set; }
        [Key(4)] public long AdderSuid { get; set; }
    }

    [MessagePackObject]
    public class AddDashBoardMemberRes : ProtocolRes
    {
        [Key(2)] public bool Success { get; set; }
        [Key(3)] public int NewMemberSeq { get; set; }
        [Key(4)] public string SoloRank { get; set; }
        [Key(5)] public string FlexRank { get; set; }
        [Key(6)] public string FixedName { get; set; }
    }
}
    
