using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class CreateDashBoardReq : Protocol
    {
        [Key(1)] public string DashBoardName { get; set; }
        [Key(2)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class CreateDashBoardRes : ProtocolRes
    {
        
    }
}
    
