using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class EditNicknameReq : Protocol
    {
        [Key(1)] public string OriginalNickname { get; set; }
        [Key(2)] public string ChangedNickname { get; set; }
    }

    [MessagePackObject]
    public class EditNicknameRes : ProtocolRes
    {
        [Key(2)] public bool Success { get; set; }
    }
}
    
