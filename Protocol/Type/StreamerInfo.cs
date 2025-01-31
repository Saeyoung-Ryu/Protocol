using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class StreamerInfo
{
    public string Name { get; set; }
    public LineType LineType { get; set; }
    public string PlatformName { get; set; }
    public int WinCount { get; set; }
    public int LoseCount { get; set; }
    
    public Tier SoloRankTier { get; set; }
    public int TierScore { get; set; }
    
    public Platform Platform { get; set; }
    public string PlatformAddress { get; set; }
}