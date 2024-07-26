using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class DashBoardInfoLobby
{
    [Key(0)] public int DashBoardSeq { get; set; }
    [Key(1)] public string Name { get; set; }
    [Key(2)] public string MasterName { get; set; }
    [Key(3)] public int Point { get; set; }
    [Key(4)] public int FavoriteCount { get; set; }
    [Key(5)] public DashBoardPosition Position { get; set; }
}