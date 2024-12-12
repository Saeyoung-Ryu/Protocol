using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class DivideBalanceTeamReq : Protocol
    {
        [Key(1)] public long Suid { get; set; }
        [Key(2)] public int DashBoardSeq { get; set; }
        [Key(3)] public string Region { get; set; }
        [Key(4)] public List<TeamMember> Members { get; set; }
    }

    [MessagePackObject]
    public class DivideBalanceTeamRes : ProtocolRes
    {
        public List<BalanceInfo> Team1Balance { get; set; }
        public List<BalanceInfo> Team2Balance { get; set; }
        public int UpdateRemainTime { get; set; }
    }
}
    
