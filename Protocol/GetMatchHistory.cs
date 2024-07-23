using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetMatchHistoryReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
    }

    [MessagePackObject]
    public class GetMatchHistoryRes : ProtocolRes
    {
        [Key(2)] public List<MatchHistory> MatchHistoryList { get; set; }
    }
}
    
