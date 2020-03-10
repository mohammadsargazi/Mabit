using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Services.BookingService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    public class ResidenceController : BaseController<ResidenceController>
    {
        #region Fileds
        private readonly BookingService _bookingService = new BookingService();

        #endregion

        #region Const 
        public ResidenceController(ILogger<ResidenceController> logger, SharedCultureLocalizer loc)
            : base(logger, loc)
        {

        }
        #endregion
        public IActionResult Index()
        {
            
            return View();
        }
    }
}