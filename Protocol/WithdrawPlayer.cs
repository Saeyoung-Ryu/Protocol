using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class WithdrawPlayerReq : Protocol
    {
        [Key(1)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class WithdrawPlayerRes : ProtocolRes
    {
    }
}
    
