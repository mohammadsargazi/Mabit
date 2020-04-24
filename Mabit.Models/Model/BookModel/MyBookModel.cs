using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.BookModel
{
    public class MyBookModel
    {
        public int bookId { get; set; }
        public string pictureUrl { get; set; }
        public string title { get; set; }
        public City city { get; set; }
        public Province province { get; set; }
        public Country country { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string cost { get; set; }
        public bookStatus bookStatus { get; set; }
        public int bookStatusId { get; set; }
    }

    #region RelationalModel
    public class bookStatus
    {
        public int id { get; set; }
        public string title { get; set; }
    }
    #endregion
}
