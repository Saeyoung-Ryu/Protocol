using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class UpdateMemberReq : Protocol
    {
        [Key(1)] public int Seq { get; set; }
        [Key(2)] public string Region { get; set; }
    }

    [MessagePackObject]
    public class UpdateMemberRes : ProtocolRes
    {
        [Key(2)] public string Name { get; set; }
        [Key(3)] public string SoloRank { get; set; }
        [Key(4)] public string FlexRank { get; set; }
    }
}
    
