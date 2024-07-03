using MessagePack;

namespace Protocol;

[MessagePackObject]
public class ProtocolReq
{
    [Key(0)] public Protocol Protocol { get; set; }
}