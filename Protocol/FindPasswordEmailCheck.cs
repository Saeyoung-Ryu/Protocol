using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class FindPasswordEmailCheckReq : Protocol
    {
        [Key(1)] public string Email { get; set; }
    }

    [MessagePackObject]
    public class FindPasswordEmailCheckRes : ProtocolRes
    {
        [Key(2)] public bool Exist { get; set; }
    }
}
    
