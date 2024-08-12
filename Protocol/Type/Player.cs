using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class Player
{
    [Key(0)] public long Suid { get; set; }
    [Key(1)] public string AccountId { get; set; }
    [Key(2)] public string AccountPass { get; set; }
    [Key(3)] public LoginType LoginType { get; set; }
    [Key(4)] public string Nickname { get; set; }
    [Key(5)] public string Email { get; set; }
    [Key(6)] public string Password { get; set; }
    [Key(7)] public string PasswordSalt { get; set; }
    [Key(8)] public DateTime CreateTime { get; set; }
    [Key(9)] public PremiumType PremiumType { get; set; }
    
    public int CreateAbleDashBoardCount { get; set; }
    
    public int MaxDashBoardCount { get; set; }
    public int MaxMemberCount { get; set; }
    public int MaxDailyTicketCount { get; set; }
    public int AttendanceDay { get; set; }
    public List<int> FavoritedashBoardSeqList { get; set; } = new List<int>();
    public DateTime LastLoginTime { get; set; }
    public bool RememberMe { get; set; }
}