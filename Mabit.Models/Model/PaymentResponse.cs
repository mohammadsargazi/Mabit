using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class PaymentResponse:BaseModel
    {
        public PaymentRequest PaymentRequest { get; set; }
        public int PaymentRequestId { get; set; }
        public PaymentResponseResult PaymentResponseResult { get; set; }
        public int PaymentResponseResultId { get; set; }
        public List<UserFinancialRecord> UserFinancialRecords { get; set; }

    }
}
