using MessagePack;
using Protocol.Enum;

namespace Protocol
{
    [MessagePackObject]
    public class GetMatchHistoryReq : Protocol
    {
        [Key(1)] public string NickName { get; set; }
    }

    [MessagePackObject]
    public class GetMatchHistoryRes : ProtocolRes
    {
        [Key(2)] public List<Dictionary<WinLoseType, string>> MatchHistoryListDic { get; set; }
    }
}
    
