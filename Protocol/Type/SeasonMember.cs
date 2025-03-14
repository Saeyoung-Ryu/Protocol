using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

public class SeasonMember
{
    public string Name { get; set; }
    public string? Tag { get; set; }
    public int SupWinCount { get; set; }
    public int SupLoseCount { get; set; }
    public int AdcWinCount { get; set; }
    public int AdcLoseCount { get; set; }
    public int MidWinCount { get; set; }
    public int MidLoseCount { get; set; }
    public int JgWinCount { get; set; }
    public int JgLoseCount { get; set; }
    public int TopWinCount { get; set; }
    public int TopLoseCount { get; set; }
    
    public int SoloRankBattlePoint { get; set; }
    public int BattleCount { get; set; }
    
    public int AramWinCount { get; set; }
    public int AramLoseCount { get; set; }
    
    public int TopPoint { get; set; }
    public int JunglePoint { get; set; }
    public int MidPoint { get; set; }
    public int AdcPoint { get; set; }
    public int SupPoint { get; set; }
    
    public int TotalWinCount { get { return SupWinCount + AdcWinCount + MidWinCount + JgWinCount + TopWinCount; } }
    public int TotalLoseCount  { get { return SupLoseCount + AdcLoseCount + MidLoseCount + JgLoseCount + TopLoseCount; } }
}