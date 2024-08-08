using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class PremiumInfo
{
    public PremiumType PremiumType { get; set; }
    public int AttendanceDay { get; set; }
    public int MaxMember { get; set; }
    public int CreateDashBoardCount { get; set; }
    public int DailyTicketCount { get; set; }
}