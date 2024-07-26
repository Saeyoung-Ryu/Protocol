using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class RateLimitTestReq : Protocol
    {
        [Key(1)] public string TestMessage { get; set; }
    }

    [MessagePackObject]
    public class RateLimitTestRes : ProtocolRes
    {
    }
}
    
