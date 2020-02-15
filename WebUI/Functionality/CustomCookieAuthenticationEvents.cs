using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Functionality
{
    public class CustomCookieAuthenticationEvents : CookieAuthenticationEvents
    {
        public override Task RedirectToLogin(RedirectContext<CookieAuthenticationOptions> context)
        {
            var httpContext = context.HttpContext;

            var routePrefix = httpContext.GetRouteValue("culture");

            context.RedirectUri = $"/{routePrefix.ToString()}/Account/Login";
            return base.RedirectToLogin(context);
        }
    }
}
