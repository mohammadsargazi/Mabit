using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomLocationOption:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public LocationOption LocationOption { get; set; }
        public int LocationOptionId { get; set; }
    }
}
