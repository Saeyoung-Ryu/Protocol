using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class LoadDataReq : Protocol
    {
        [Key(1)] public Player Player { get; set; }
    }

    [MessagePackObject]
    public class LoadDataRes : ProtocolRes
    {
        [Key(2)] public PlayerAttendance PlayerAttendance { get; set; }
    }
}
    
