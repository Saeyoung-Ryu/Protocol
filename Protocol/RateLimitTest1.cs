using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class RateLimitTest1Req : Protocol
    {
        [Key(1)] public string TestMessage { get; set; }
    }

    [MessagePackObject]
    public class RateLimitTest1Res : ProtocolRes
    {
    }
}
    
