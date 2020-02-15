using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomCustomRule:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public CustomRule CustomRule { get; set; }
        public int CustomRuleId { get; set; }


    }
}
