using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class CreateDashBoardReq : Protocol
    {
        [Key(1)] public string DashBoardName { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public string MasterName { get; set; }
        [Key(4)] public string Notification { get; set; }
        [Key(5)] public string Region { get; set; }
    }

    [MessagePackObject]
    public class CreateDashBoardRes : ProtocolRes
    {
        
    }
}
    
