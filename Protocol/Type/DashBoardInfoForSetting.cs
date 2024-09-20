using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class DashBoardInfoForSetting
{
    [Key(0)] public int DashBoardSeq { get; set; }
    [Key(1)] public DashBoardPosition Position { get; set; }
    [Key(2)] public List<Manager> Managers { get; set; }
    [Key(3)] public string DashBoardNotification { get; set; }
    [Key(4)] public string DashBoardNotificationNext { get; set; }
    [Key(5)] public bool IsDiscordConnected { get; set; }
}