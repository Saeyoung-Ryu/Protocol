using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class FindPasswordVerificationCodeCheckReq : Protocol
    {
        [Key(1)] public string Code { get; set; }
        [Key(2)] public string Email { get; set; }
    }

    [MessagePackObject]
    public class FindPasswordVerificationCodeCheckRes : ProtocolRes
    {
        [Key(2)] public bool SuccessVerify { get; set; }
    }
}
    
