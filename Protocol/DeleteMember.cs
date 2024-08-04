using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class DeleteMemberReq : Protocol
    {
        [Key(1)] public int MemberSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class DeleteMemberRes : ProtocolRes
    {
    }
}
    
