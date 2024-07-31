using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class GetMySettingDashBoardInfosReq : Protocol
    {
        [Key(1)] public long Suid { get; set; }
    }

    [MessagePackObject]
    public class GetMySettingDashBoardInfosRes : ProtocolRes
    {
        [Key(2)] public Dictionary<string, DashBoardInfoForSetting> Dictionary { get; set; }
    }
}
    
