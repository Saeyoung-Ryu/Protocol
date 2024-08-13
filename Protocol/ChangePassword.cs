using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class ChangePasswordReq : Protocol
    {
        [Key(1)] public string CurrentPassword { get; set; }
        [Key(2)] public string NewPassword { get; set; }
        [Key(3)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class ChangePasswordRes : ProtocolRes
    {
        public string AccountPass { get; set; }
    }
}
    
