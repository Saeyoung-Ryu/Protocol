using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class SoloRankMatchHistoryInfo
{
    [Key(0)] public int Seq { get; set; }
    [Key(1)] public DateTime Time { get; set; }
    [Key(2)] public List<SoloRankMember> Team1Data { get; set; }
    [Key(3)] public List<SoloRankMember> Team2Data { get; set; }
    [Key(4)] public List<SoloRankMember> Team3Data { get; set; }
    [Key(5)] public List<SoloRankMember> Team4Data { get; set; }
    [Key(6)] public int RemainTime { get; set; }
    [Key(7)] public int GameCount { get; set; }
    [Key(8)] public bool Calculated { get; set; }
    [Key(9)] public string CreatorName { get; set; }
}