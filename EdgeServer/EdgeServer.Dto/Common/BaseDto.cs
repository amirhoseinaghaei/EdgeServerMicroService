using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeServer.Dto.Common
{
    [MessagePackObject]
    public class BaseDto
    {
        [Key(1)]
        public int Id { get; set; }
    }
}
