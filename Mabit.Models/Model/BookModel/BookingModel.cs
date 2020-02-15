using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.BookModel
{
    public class BookingModel
    {
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public int roomId { get; set; }
        public int peopleCount { get; set; }
    }
}
