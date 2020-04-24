using Mabit.Models.Model.BookModel;
using Mabit.Models.Model.Common;
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
            if (culture == "fa")
            {
                bookingModel.fromDate = bookingModel.fromDate.ToGregorianDate().ToString();
                bookingModel.toDate = bookingModel.toDate.ToGregorianDate().ToString();
            }
            return HttpHelper.Post<BookInvoiceModel, BookingModel>("api/Booking/GetBookInvoice", culture, bookingModel)
                .Result;
        }
        public SubmitedModel BookRoom(BookingModel bookingModel, string token)
        {
            if (culture == "fa")
            {
                bookingModel.fromDate = bookingModel.fromDate.ToGregorianDate().ToString();
                bookingModel.toDate= bookingModel.toDate.ToGregorianDate().ToString();
            }
            return HttpHelper.Post<SubmitedModel, BookingModel>("api/Booking/BookRoom", culture, bookingModel, token)
                .Result;
        }
        public List<MyBookModel> MyBooks(string token)
        {
            return HttpHelper.GetAllWithPost<MyBookModel>("/api/Booking/MyBooks", culture, token).Result;
        }
        public SubmitedModel CancelBook(CancelBookModel cancelBookModel, string token)
        {
            return HttpHelper.Post<SubmitedModel,CancelBookModel>("/api/Booking/CancelBook", culture, cancelBookModel, token).Result;
        }
    }
}
