using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class SetRankReq : Protocol
    {
        [Key(1)] public string WinnerNickname { get; set; }
        [Key(2)] public string LoserNickname { get; set; }
    }

    [MessagePackObject]
    public class SetRankRes : ProtocolRes
    {
        
    }
}
    
