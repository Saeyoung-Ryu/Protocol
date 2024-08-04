using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class EditNotificationReq : Protocol
    {
        [Key(1)] public string Notification { get; set; }
        [Key(2)] public int DashBoardSeq { get; set; }
        [Key(3)] public int MasterSuid { get; set; } // 혹시나 마스터아닌사람이 수정할수있게될수도
    }

    [MessagePackObject]
    public class EditNotificationRes : ProtocolRes
    {
    }
}
    
