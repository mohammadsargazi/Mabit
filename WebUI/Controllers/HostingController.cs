using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Models.Model.RoomModel;
using Mabit.Services.CommonService;
using Mabit.Services.RoomService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HostingController : BaseController<HostingController>
    {
        #region Fileds
        private readonly CommonService _commonService = new CommonService();
        private readonly RoomService _roomService = new RoomService();
        #endregion

        #region Const 
        public HostingController(ILogger<HostingController> logger, SharedCultureLocalizer loc)
            : base(logger, loc)
        {

        }

        #endregion

        #region Actions
        public IActionResult Index()
        {
            var options = _commonService.Options();
            var textureOptions = _commonService.TextureOptions();
            var structures = _commonService.Structures();
            var roomTypes = _commonService.RoomTypes();
            var locationOptions = _commonService.LocationOptions();
            var locationTypes = _commonService.LocationTypes();
            var customRules = _commonService.CustomRules();
            var countries = _commonService.GetCountries();
            var model = new HostingViewModel
            {
                Options = options,
                CustomRules = customRules,
                LocationOptions = locationOptions,
                LocationTypes = locationTypes,
                RoomTypes = roomTypes,
                Structures = structures,
                TextureOptions = textureOptions,
                Countries = countries
            };
            return View(model);
        }

        public IActionResult AddRoom(AddRoomViewModel model)
        {
            var newRoom = model.ToModel();
           // var jsonModel= JsonConvert.DeserializeObject<AddRoomModel>(newRoom.ToString());
            _roomService.AddRoom(newRoom);
            return Json(true);
        }
        #endregion
    }
}