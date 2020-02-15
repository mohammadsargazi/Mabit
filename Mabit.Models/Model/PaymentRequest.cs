using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class PaymentRequest:BaseModel
    {
        public double Price { get; set; }
        public List<UserBookedRoomPaymentRequest> UserBookedRoomPaymentRequests { get; set; }
        public List<PaymentResponse> PaymentResponses { get; set; }
    }
}
