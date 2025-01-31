using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetStreamerRankReq : Protocol
    {
        
    }

    [MessagePackObject]
    public class GetStreamerRankRes : ProtocolRes
    {
        [Key(2)] public List<StreamerInfo> StreamerInfos { get; set; }
    }
}
    
