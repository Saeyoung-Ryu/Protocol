using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class Member
{
    public int Seq { get; set; }
    public int DashBoardSeq { get; set; }
    public string Name { get; set; }
    public bool Enable { get; set; }
}