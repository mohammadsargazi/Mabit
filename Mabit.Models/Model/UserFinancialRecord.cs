using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class UserFinancialRecord:BaseModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public int PaymentResponseId { get; set; }

    }
}
