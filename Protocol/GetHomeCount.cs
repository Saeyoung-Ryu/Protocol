using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetHomeCountReq : Protocol
    {

    }

    [MessagePackObject]
    public class GetHomeCountRes : ProtocolRes
    {
        public int PlayerCount { get; set; }
        public int MatchCount { get; set; }
    }
}