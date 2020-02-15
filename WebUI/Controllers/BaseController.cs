using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public partial class BaseController<T> : Controller where T : Controller
    {
        #region Fields
        private readonly ILogger<T> _logger;

        // To localize backend strings inject SahredCultureLocalizer
        private readonly SharedCultureLocalizer _loc;
        #endregion

        #region Const 
        public BaseController(ILogger<T> logger, SharedCultureLocalizer loc)
        {
            _logger = logger;
            _loc = loc;
        }
        #endregion
    }
}
