using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class DelegateMasterReq : Protocol
    {
        [Key(1)] public long CurrentMasterSuid { get; set; }
        [Key(2)] public string DelegatedEmail { get; set; }
        [Key(2)] public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class DelegateMasterRes : ProtocolRes
    {
    }
}
    
