using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetPremiumInfosReq : Protocol
    {
        
    }

    [MessagePackObject]
    public class GetPremiumInfosRes : ProtocolRes
    {
        [Key(2)] public Dictionary<PremiumType, PremiumInfo> PremiumInfoDic { get; set; }
    }
}
    
