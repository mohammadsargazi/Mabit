using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Models.Model;
using Mabit.Models.Model.Common;
using Mabit.Models.Model.RoomModel;
using Mabit.Services.CommonService;
using Mabit.Services.RoomService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RoomController : BaseController<RoomController>
    {
        #region Fields
        private readonly RoomService _roomService = new RoomService();
        private readonly CommonService _commonService = new CommonService();
        #endregion

        #region Const 
        public RoomController(ILogger<RoomController> logger, SharedCultureLocalizer loc)
            : base(logger, loc) { }

        #endregion

        #region Actions

        public IActionResult Search(string wherTo, string from, string to, int page = 1)
        {
            var reservationRoomModel = new ReservationRoomModel();
            DateTime dDate;

            if (DateTime.TryParse(from, out dDate) || from.Equals("C"))
            {
                reservationRoomModel.checkinDate = from;
                reservationRoomModel.checkoutDate = to;
                reservationRoomModel.city = wherTo;
            }
            else
            {
                reservationRoomModel.city = wherTo;
            }
            reservationRoomModel.peopleCount = null;
            reservationRoomModel.roomTypeId = null;
            reservationRoomModel.fromPrice = null;
            reservationRoomModel.toPrice = null;
            reservationRoomModel.take = 10;
            reservationRoomModel.skip = (page - 1) * 10;
            reservationRoomModel.roomCount = null;
            reservationRoomModel.bedCount = null;
            var model = _roomService.GetReservationRoom(reservationRoomModel);
            ViewBag.Country = _commonService.GetCountries();
            ViewBag.PageCount = 10;//Convert.ToInt32(model.count / 10);
            //var model = new List<Mabit.Models.Model.Common.TopRoom>();
            return View("Rooms", model.items);
        }
        public IActionResult SearchRooms(ReservationRoomModel reservationRoomModel)
        {
            if (reservationRoomModel.checkoutDate.Contains("C"))
            {
                reservationRoomModel.checkinDate = null;
                reservationRoomModel.checkoutDate = null;
            }
            reservationRoomModel.take = 10;
            reservationRoomModel.skip = (reservationRoomModel.page - 1) * 10;
            if (reservationRoomModel.countryId == 0)
                reservationRoomModel.countryId = null;
            if (reservationRoomModel.provinceId == 0)
                reservationRoomModel.provinceId = null;
            if (reservationRoomModel.peopleCount == 0)
                reservationRoomModel.peopleCount = null;
            if (reservationRoomModel.roomCount == 0)
                reservationRoomModel.roomCount = null;
            if (reservationRoomModel.bedCount == 0)
                reservationRoomModel.bedCount = null;
            if (!reservationRoomModel.isPriceRangeChecked)
            {
                reservationRoomModel.fromPrice = null;
                reservationRoomModel.toPrice = null;
            }
            reservationRoomModel.roomTypeId = null;


            var model = _roomService.GetReservationRoom(reservationRoomModel);
            return View("_SearchRooms", model.items);
        }
        public IActionResult SeeAll()
        {
            var reservationRoomModel = new ReservationRoomModel
            {
                checkinDate = null,
                checkoutDate = null,
                city = null,
                fromPrice = null,
                peopleCount = null,
                roomTypeId = null,
                skip = 0,
                take = 10,
                toPrice = null
            };
            var model = _roomService.GetReservationRooms(reservationRoomModel);
            ViewBag.Country = _commonService.GetCountries();

            //var model = new List<Mabit.Models.Model.Common.TopRoom>();
            return View("Rooms", model);
        }
        public IActionResult GetProvince(int countryId)
        {
            var res = _commonService.GetProvince(countryId);
            return Json(res);
        }
        public IActionResult GetCity(int provinceId)
        {
            var res = _commonService.GetCity(provinceId);
            return Json(res);
        }
        public IActionResult Rooms(string wherTo, string from, string to)
        {
            var searchModelResult = _roomService.SearchRoom(new SearchRoomModel());
            return View(searchModelResult);
        }
        public IActionResult Detail(int id)
        {
            var model = _roomService.Get(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Room model)
        {
            var res = _roomService.Post(model);
            return RedirectToAction("Index");
        }
        public IActionResult Get()
        {
            var res = _roomService.GetAll();
            return RedirectToAction("Index");
        }
        public IActionResult Date()
        {
            return View();
        }
        #endregion

    }
}