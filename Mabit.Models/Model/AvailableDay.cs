using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class AvailableDay:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public UserBookedRoom UserBookedRoom { get; set; }
        public int UserBookedRoomId { get; set; }

    }
}
