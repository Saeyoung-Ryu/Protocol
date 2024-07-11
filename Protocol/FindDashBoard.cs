using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class FindDashBoardReq : Protocol
    {
        [Key(1)] public string DashBoardName { get; set; }
    }

    [MessagePackObject]
    public class FindDashBoardRes : ProtocolRes
    {
        [Key(2)] public bool Exist { get; set; }
    }
}
    
