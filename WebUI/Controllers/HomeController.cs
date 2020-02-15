using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Services.CommonService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
    //[Authorize]
    public class HomeController : BaseController<HomeController>
    {
        #region Fileds
        private readonly CommonService _commonService = new CommonService();
 
        #endregion

        #region Const 
        public HomeController(ILogger<HomeController> logger, SharedCultureLocalizer loc) 
            : base(logger, loc) {
     
        }

        #endregion

        #region Actions
       
        public IActionResult Index()
        {
           
            var topCities = _commonService.GetTopCities();
            var topRooms = _commonService.GetTopRooms();
            var Countries = _commonService.Countries();
            var model = new HomeViewModel()
            {
                TopCities = topCities,
                TopRooms = topRooms
            };
            //ViewBag.TopRoomS = topRooms;
            //ViewBag.TopCities = topCities;
            ViewBag.Countries = Countries;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

    }
}
