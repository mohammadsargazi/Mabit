using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class UserController :BaseController<UserController>
    {
        #region Const 
        public UserController(ILogger<UserController> logger, SharedCultureLocalizer loc)
            : base(logger, loc) { }

        #endregion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Massage()
        {
            return View();
        }
    }
}