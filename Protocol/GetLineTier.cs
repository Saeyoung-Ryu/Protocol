using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetLineTierReq : Protocol
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Region { get; set; }
        public string RegionForUrl { get; set; }
    }

    [MessagePackObject]
    public class GetLineTierRes : ProtocolRes
    {
        public string Name { get; set; }
        public List<LineTierInfo> LineTierInfos { get; set; }
    }
}