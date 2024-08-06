using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class DeleteManagerReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public string EmailToDelete { get; set; }
        [Key(3)] public long MasterSuid { get; set; } // 혹시나 마스터아닌사람이 수정할수있게될수도
    }

    [MessagePackObject]
    public class DeleteManagerRes : ProtocolRes
    {
        
    }
}
    
