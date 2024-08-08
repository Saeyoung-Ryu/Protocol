using MessagePack;
using Protocol.Enum;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class LoadDataReq : Protocol
    {
        [Key(1)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class LoadDataRes : ProtocolRes
    {
        [Key(2)] public PremiumType PremiumType { get; set; }
        [Key(3)] public List<DashBoardInfoLobby> FavoriteDashBoardInfos { get; set; }
        [Key(4)] public List<DashBoardInfoLobby> ManagingDashBoardInfos { get; set; }
        [Key(5)] public int CreateAbleDashBoard { get; set; }
        [Key(6)] public List<DashBoardInfoLobby> DashBoardInviteInfos { get; set; }
        [Key(7)] public int MaxDashBoardCount { get; set; }
        [Key(8)] public int MaxMemberCount { get; set; }
        [Key(9)] public int MaxDailyTicketCount { get; set; }
        [Key(10)] public int AttendanceDay { get; set; }
    }
}
    
