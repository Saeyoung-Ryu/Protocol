using System;
using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

public class SummonerInfo
{
    public int IconId { get; set; }
    
    public string SoloRank { get; set; }
    public int SoloWin { get; set; }
    public int SoloLose { get; set; }
    
    public string FlexRank { get; set; }
    public int FlexWin { get; set; }
    public int FlexLose { get; set; }
    
    public List<long> MasteryTop5 { get; set; }
}