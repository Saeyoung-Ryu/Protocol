using System;
using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

public class BalanceInfo
{
    public string Name { get; set; }
    public int Seq { get; set; }
    public int TmmScore { get; set; }
    public LineType LineType { get; set; }
    public string TopTier { get; set; }
    public int TopMastery { get; set; }
    public string JgTier { get; set; }
    public int JgMastery { get; set; }
    public string MidTier { get; set; }
    public int MidMastery { get; set; }
    public string AdcTier { get; set; }
    public int AdcMastery { get; set; }
    public string SupportTier { get; set; }
    public int SupportMastery { get; set; }

    private int TotalMastery => TopMastery + JgMastery + MidMastery + AdcMastery + SupportMastery;

    public double TopMasteryPercentage => TotalMastery == 0 ? 0 : Math.Round((double)TopMastery / TotalMastery * 100, 1);
    public double JgMasteryPercentage => TotalMastery == 0 ? 0 : Math.Round((double)JgMastery / TotalMastery * 100, 1);
    public double MidMasteryPercentage => TotalMastery == 0 ? 0 : Math.Round((double)MidMastery / TotalMastery * 100, 1);
    public double AdcMasteryPercentage => TotalMastery == 0 ? 0 : Math.Round((double)AdcMastery / TotalMastery * 100, 1);
    public double SupportMasteryPercentage => TotalMastery == 0 ? 0 : Math.Round((double)SupportMastery / TotalMastery * 100, 1);
}