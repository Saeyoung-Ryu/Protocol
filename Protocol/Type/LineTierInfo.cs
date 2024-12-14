using System;
using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

public class LineTierInfo
{
    public LineType LineType { get; set; }
    public List<int> ChampList { get; set; }
    public int MasteryScore { get; set; }
    public string Tier { get; set; }
}