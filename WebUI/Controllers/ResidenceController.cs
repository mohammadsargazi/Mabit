using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class ResidenceController : Controller
    {
        #region Fields
        private readonly ILogger<HomeController> _logger;

        // To localize backend strings inject SahredCultureLocalizer
        private readonly SharedCultureLocalizer _loc;
        #endregion

        #region Const 
        public ResidenceController(ILogger<HomeController> logger, SharedCultureLocalizer loc)
        {
            _logger = logger;
            _loc = loc;
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }
    }
}