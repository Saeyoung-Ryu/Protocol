using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class SignInEmailAuthVerifyStepReq : Protocol
    {
        [Key(1)] public string Email { get; set; }
        [Key(2)] public string Code { get; set; }
        [Key(3)] public string ClientCode { get; set; }
    }

    [MessagePackObject]
    public class SignInEmailAuthVerifyStepRes : ProtocolRes
    {
        [Key(2)] public bool VerifyResult { get; set; }
    }
}
    
