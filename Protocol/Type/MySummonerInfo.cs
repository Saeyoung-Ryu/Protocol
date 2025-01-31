using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class MySummonerInfo
{
    public string Name { get; set; }
    public int IconId { get; set; }
    public int WinCount { get; set; }
    public int LoseCount { get; set; }
    
    public string SoloRankTier { get; set; }
    public int TierScore { get; set; }
}