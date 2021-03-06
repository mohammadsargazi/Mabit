﻿using System;
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
    public class ReservationController : BaseController<ReservationController>
    {
        #region Fields
        private readonly BookingService _bookingService = new BookingService();
        #endregion

        #region Const 
        public ReservationController(ILogger<ReservationController> logger, SharedCultureLocalizer loc)
            : base(logger, loc) { }

        #endregion

        #region Actions
        public IActionResult Index()
        {
            var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
            var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
            var model = _bookingService.MyBooks(token);
            return View(model);
        }

        public IActionResult List()
        {
            return View();
        }
        public IActionResult CancelBook(int id)
        {
            var cancelBookModel = new CancelBookModel
            {
                bookId = id
            };
            var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
            var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
            var res = _bookingService.CancelBook(cancelBookModel, token).submited;
            return Json(res);
        }
        #endregion
    }
}