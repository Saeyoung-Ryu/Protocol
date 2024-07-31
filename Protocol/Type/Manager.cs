using MessagePack;
using Protocol.Enum;

namespace Protocol.Type;

[MessagePackObject]
public class Manager
{
    public string Name { get; set; }
    public string Email { get; set; }
}