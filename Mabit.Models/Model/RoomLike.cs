using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomLike:BaseModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }

    }
}
