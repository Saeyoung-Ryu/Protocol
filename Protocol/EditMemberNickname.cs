using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class EditMemberNicknameReq : Protocol
    {
        [Key(1)] public string OriginalNickname { get; set; }
        [Key(2)] public string ChangedNickname { get; set; }
        [Key(3)] public long Suid { get; set; }
        [Key(4)] public int DashBoardSeq { get; set; }
        [Key(5)] public int MemberSeq { get; set; }
    }

    [MessagePackObject]
    public class EditMemberNicknameRes : ProtocolRes
    {
        
    }
}
    
