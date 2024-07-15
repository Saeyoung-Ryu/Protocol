using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class CheckNicknameDuplicatedReq : Protocol
    {
        [Key(1)] public string Nickname { get; set; }
    }

    [MessagePackObject]
    public class CheckNicknameDuplicatedRes : ProtocolRes
    {
        [Key(2)] public bool IsDuplicated { get; set; }
    }
}
    
