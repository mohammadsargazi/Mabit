using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Services.CommonService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class CommonController : BaseController<CommonController>
    {
        #region Fields
        private readonly CommonService _commonService = new CommonService();
        #endregion

        #region Const 
        public CommonController(ILogger<CommonController> logger, SharedCultureLocalizer loc)
            : base(logger, loc) { }

        #endregion

        public IActionResult GetCountries()
        {
            var model = _commonService.GetCountries();
            return Json(model);
        }
        public IActionResult GetProvince(int countryId)
        {
            var model = _commonService.GetProvince(countryId);
            return Json(model);
        }
        public IActionResult GetCity(int provinceId)
        {
            var model = _commonService.GetCity(provinceId);
            return Json(model);
        }
    }
}