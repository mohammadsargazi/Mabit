using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class UserBookedRoom : BaseModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public List<AvailableDay> AvailableDays { get; set; }
        public bool Accepted { get; set; }
        public List<CancelledUserBookedRoom> CancelledUserBookedRooms { get; set; }
        public List<UserBookedRoomPaymentRequest> UserBookedRoomPaymentRequests { get; set; }

    }
}
