using EdgeServer.Dto.Common;
using MessagePack;

namespace EdgeServer.Dto
{
    [MessagePackObject]
    public class UserRequestDto : BaseDto
    {
        [Key(2)]
        public int DigitalTwinId { get; set; }
        [Key(3)]
        public int EdgeServerId { get; set; }
        [Key(4)]
        public string EdgeServerName { get; set; }

    }
}