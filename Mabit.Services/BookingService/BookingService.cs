using Mabit.Models.Model.BookModel;
using Mabit.Services.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Services.BookingService
{
    public class BookingService
    {
        #region Fields
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        #endregion
        public BookInvoiceModel GetBookInvoice(BookingModel bookingModel)
        {
            return HttpHelper.Post<BookInvoiceModel, BookingModel>("api/Booking/GetBookInvoice", culture, bookingModel)
                .Result;
        }

        public List<MyBookModel> MyBooks(string token)
        {
            return HttpHelper.GetAllWithAuthentication<MyBookModel>("/api/Booking/MyBooks", token, culture).Result;
        }

    }
}
