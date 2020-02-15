using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomOption:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public Option Option { get; set; }
        public int OptionId { get; set; }

    }
}
