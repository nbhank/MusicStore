using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MvcMusicStore.Controllers
{
    public class SharedResources : Controller
    {
        public static IStringLocalizer StringLocalizer { get; set; }

    }
}