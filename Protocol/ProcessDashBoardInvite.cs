using MessagePack;
using Protocol.Type;

namespace Protocol
{
    [MessagePackObject]
    public class ProcessDashBoardInviteReq : Protocol
    {
        [Key(1)] public int DashBoardSeq { get; set; }
        [Key(2)] public long Suid { get; set; }
        [Key(3)] public bool Accepted { get; set; }
    }

    [MessagePackObject]
    public class ProcessDashBoardInviteRes : ProtocolRes
    {
        [Key(2)] public DashBoardInfoLobby DashBoardInfoLobby { get; set; }
    }
}
    
