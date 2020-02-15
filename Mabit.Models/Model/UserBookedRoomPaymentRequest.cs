using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class UserBookedRoomPaymentRequest : BaseModel
    {
        public UserBookedRoom UserBookedRoom { get; set; }
        public int UserBookedRoomId { get; set; }
        public PaymentRequest PaymentRequest { get; set; }
        public int PaymentRequestId { get; set; }
    }
}
