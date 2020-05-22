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

        // This method helps to get the error information from the MVC "ModelState".
        // We can not directly send the ModelState to the client in Json. The "ModelState"
        // object has some circular reference that prevents it to be serialized to Json.
        public Dictionary<string, object> GetErrorsFromModelState()
        {
            var errors = new Dictionary<string, object>();
            foreach (var key in ModelState.Keys)
            {
                // Only send the errors to the client.
                if (ModelState[key].Errors.Count > 0)
                {
                    errors[key] = ModelState[key].Errors;
                }
            }

            return errors;
        }
    }
}
