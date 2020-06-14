﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Models.Model.Common;
using Mabit.Models.Model.RoomModel;
using Mabit.Services.CommonService;
using Mabit.Services.HotelService;
using Mabit.Services.RoomService;
using Microsoft.AspNetCore.Http;
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
        private readonly HotelService _hotelService = new HotelService();
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
            var categoryOptopns = new List<CategoryOption> { new CategoryOption { Id = 1, Title = "" } }; //_commonService.GetCategoryOption();
            var hotelTypes = new List<HotelType> { new HotelType { Id = 1, Title = "WIFI" } };//_commonService.GetHotelType();
            var hotelCategories = new List<BaseRelateModel> { new BaseRelateModel { id = 1, title = "" } };// _commonService.GetHotelCategory();
            var model = new HostingViewModel
            {
                Options = options,
                CustomRules = customRules,
                LocationOptions = locationOptions,
                LocationTypes = locationTypes,
                RoomTypes = roomTypes,
                Structures = structures,
                TextureOptions = textureOptions,
                Countries = countries,
                HotelTypes = hotelTypes,
                CategoryOptions = categoryOptopns,
                HotelCategories = hotelCategories
            };
            return View(model);
        }

        public IActionResult List()
        {
            var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
            var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
            var model = _roomService.MyRooms(token);
            return View(model);
        }

        public IActionResult AddRoom(AddRoomViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRoom = model.ToModel();
                var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
                var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
                var res = _roomService.AddRoom(newRoom, token).submited;
                return Json(new
                {
                    Valid = true
                });
            }
            return Json(new
            {
                Valid = false,
                Errors = GetErrorsFromModelState()
            });
        }

        public IActionResult AddCategoryHotel(AddCategoryHotelViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newCategoryHotel = model.ToModel();
                var claims = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims;
                var token = claims.SingleOrDefault(x => x.Type == "AcessToken").Value;
                var res = _hotelService.AddHotelCategory(newCategoryHotel, token).submited;
                return Json(new
                {
                    Valid = true
                });
            }
            return Json(new
            {
                Valid = false,
                Errors = GetErrorsFromModelState()
            });
        }



        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

        [HttpPost]
        public IActionResult Upload(IList<IFormFile> files)
        {
            var fileIds = new List<int>();
            foreach (IFormFile file in files)
            {
                var newFileUploadModel = new FileUploadModel()
                {
                    base64 = Convert.ToBase64String(ReadToEnd(file.OpenReadStream())),
                    fileName = file.FileName,
                    mimeType = file.ContentType
                };
                var fileId = _commonService.UploadBase64(newFileUploadModel);
                fileIds.Add(fileId);
            }
            return Json(fileIds);
        }
        public IActionResult UploadImageString(string base64)
        {
            var newFileUploadModel = new FileUploadModel()
            {
                base64 = base64,
                fileName = "",
                mimeType = ".jpg"
            };
            var fileId = _commonService.UploadBase64(newFileUploadModel);
            return Json(fileId);
        }

        #endregion
    }
}