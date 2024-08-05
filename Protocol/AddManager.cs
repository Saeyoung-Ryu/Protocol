using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class AddManagerReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public string EmailToAdd { get; set; }
        [Key(3)] public int MasterSuid { get; set; } // 혹시나 마스터아닌사람이 수정할수있게될수도
    }

    [MessagePackObject]
    public class AddManagerRes : ProtocolRes
    {
        
    }
}
    