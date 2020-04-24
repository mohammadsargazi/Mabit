using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Models.Model.BookModel;
using Mabit.Services.BookingService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class BookingController : BaseController<BookingController>
    {
        #region Fileds
        private readonly BookingService _bookingService = new BookingService();

        #endregion

        #region Const 
        public BookingController(ILogger<BookingController> logger, SharedCultureLocalizer loc)
            : base(logger, loc)
        {

        }
        #endregion
        public IActionResult GetBookInvoice(BookingModel model)
        {
            var res = _bookingService.GetBookInvoice(model);
            return Json(res);
        }
        public IActionResult BookRoom(BookingModel model)
        {
            var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
            var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
            var res = _bookingService.BookRoom(model, token).submited;
            return Json(res);
        }
    }
}