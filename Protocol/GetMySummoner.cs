using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetMySummonerReq : Protocol
    {
        public long Suid { get; set; }
        public string Name { get; set; }
    }

    [MessagePackObject]
    public class GetMySummonerRes : ProtocolRes
    {
        [Key(2)] public MySummonerInfo MySummonerInfo { get; set; }
        public int UpdateRemainTime { get; set; }
    }
}
    
