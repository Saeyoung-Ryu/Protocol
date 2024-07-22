using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class AddDashBoardMemberReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public string NewMemberName { get; set; }
        [Key(3)] public long DashBoardMasterSuid { get; set; }
    }

    [MessagePackObject]
    public class AddDashBoardMemberRes : ProtocolRes
    {
        [Key(2)] public bool Success { get; set; }
        [Key(3)] public int NewMemberSeq { get; set; }
    }
}
    
