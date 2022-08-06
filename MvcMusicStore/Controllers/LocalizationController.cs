using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MvcMusicStore.Controllers
{
    // Web page to allow the user to select their language preference  
    public class LocalizationController : Controller
    {
        // this class property is set by startup.cs, making localization available to Models 
        public static IStringLocalizer StringLocalizer { get; set; }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture))
                //, new CookieOptions { Expires = DateTime.Now.AddDays(7) }
            );
            return LocalRedirect(returnUrl);
        }
    }

}