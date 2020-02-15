using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class PaymentResponseResult:BaseModel
    {
        public List<PaymentResponse> PaymentResponses { get; set; }
    }
}
