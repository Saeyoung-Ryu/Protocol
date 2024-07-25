using MessagePack;

namespace Protocol
{
    [MessagePackObject]
    public class SetFavoriteBoardReq : Protocol
    {
        [Key(1)] public long Suid { get; set; }
        [Key(2)] public int DashBoardSeq { get; set; }
        [Key(3)] public bool IsAdded { get; set; }
    }

    [MessagePackObject]
    public class SetFavoriteBoardRes : ProtocolRes
    {
        [Key(2)] public List<int> FavoriteDashBoardSeqList { get; set; }
    }
}
    
