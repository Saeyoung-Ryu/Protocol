using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class SignInEmailAuthFinalStepReq : Protocol
    {
        [Key(1)] public string Password { get; set; }
        [Key(2)] public string NickName { get; set; }
        [Key(3)] public string Email { get; set; }
        [Key(4)] public string ClientCode { get; set; }
        [Key(5)] public LoginType LoginType { get; set; }
    }

    [MessagePackObject]
    public class SignInEmailAuthFinalStepRes : ProtocolRes
    {
        [Key(2)] public bool FinalResult { get; set; }
        [Key(3)] public Player Player { get; set; }
    }
}
    
