using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class MemberWinLoseInfo
{
    [Key(0)] public string Name { get; set; }

    [Key(1)] public int MemberSeq { get; set; }

    [Key(2)] public int WinCount { get; set; }

    [Key(3)] public int LoseCount { get; set; }

    private double _winRate;
    private int _rankPoint;
    
    public int Rank { get; set; }

    public double WinRate
    {
        get
        {
            if (WinCount + LoseCount == 0)
                return 0;
            double winRate = (double)WinCount / (WinCount + LoseCount) * 100;
            return Math.Ceiling(winRate * 10) / 10; // Round up to one decimal place
        }
    }

    public int RankPoint
    {
        get
        {
            return WinCount * 10 - LoseCount * 7;
        }
        set
        {
            _rankPoint = value;
        }
    }
}