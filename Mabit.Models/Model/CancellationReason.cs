using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class CancellationReason:BaseModel
    {
        public List<CancelledUserBookedRoom> CancelledUserBookedRooms { get; set; }
    }
}
