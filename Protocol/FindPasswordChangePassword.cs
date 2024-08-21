using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class FindPasswordChangePasswordReq : Protocol
    {
        [Key(1)] public string NewPassword { get; set; }
        [Key(2)] public string Email { get; set; }
        [Key(3)] public string ClientCode { get; set; }
    }

    [MessagePackObject]
    public class FindPasswordChangePasswordRes : ProtocolRes
    {
        [Key(2)] public bool Success { get; set; }
    }
}
    
