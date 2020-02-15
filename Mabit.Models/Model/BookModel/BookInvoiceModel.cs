using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.BookModel
{
    public class BookInvoiceModel
    {
        public List<item> items { get; set; }
        public double sum { get; set; }
    }
    public class item
    {
        public string title { get; set; }
        public double price { get; set; }
        public double count { get; set; }

    }
}
