using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class CancelledUserBookedRoom:BaseModel
    {
        public UserBookedRoom UserBookedRoom { get; set; }
        public int UserBookedRoomId { get; set; }
        public CancellationReason CancellationReason { get; set; }
        public int CancellationReasonId { get; set; }

    }
}
