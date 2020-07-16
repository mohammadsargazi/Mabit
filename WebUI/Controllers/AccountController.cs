using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using Mabit.Models.Auth;
using Mabit.Models.Model.UserModel;
using Mabit.Services.Auth;
using Mabit.Services.Helper;
using Mabit.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;   
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthService _authService = new AuthService();
        private readonly UserService _userService = new UserService();
        private readonly ILogger<AccountController> _logger;
        private readonly string culture;
   

        // To localize backend strings inject SahredCultureLocalizer
        private readonly SharedCultureLocalizer _loc;
        public AccountController(ILogger<AccountController> logger, SharedCultureLocalizer loc)
        {
            _logger = logger;
            _loc = loc;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
           
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var RequestTokenModel = new RequestTokenModel()
            {
                UserName = model.UserName,
                Password = model.Password
            };
            var requestTokenResult = HttpHelper.RequestToken(RequestTokenModel);// .RequestToken(model.UserName, model.Password);
            if (requestTokenResult != null && requestTokenResult.Token != null)
            {
                //Create the identity for the user  
                var identity = new ClaimsIdentity(new[] {
                    
                        new Claim("usrFullName", requestTokenResult.User.firstName + " " + requestTokenResult.User.lastName),
                        new Claim("userProfileImageUrl",requestTokenResult.User.profileImageUrl),
                        new Claim ("AcessToken",string.Format("{0}", requestTokenResult.Token))
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return Json(true);
            }
            return Json(false);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Register model)
        {
            var res = _userService.Register(model);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
           
            return RedirectToAction("Index","Home");
        }
    }
}