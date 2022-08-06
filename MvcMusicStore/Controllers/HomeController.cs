using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}
        //[Authorize]
        public IActionResult About()
        {
            var mary = Request.Query["fred"];
            ViewData["Message"] = $"Your application description {mary} page.";

            HttpContext.Session.SetString("artistName", "mary");

            List<Generic2String> headers = new List<Generic2String>();
            foreach (var item in Request.Headers.Keys)
            {
                headers.Add(new Generic2String($"Request.Headers['{item}']", Request.Headers[item]));
            }
            headers.Add(new Generic2String("Request.Headers['Referer']", Request.Headers["Referer"]));
            headers.Add(new Generic2String("Request.Host", Request.Host.ToString()));
            headers.Add(new Generic2String("Request.HttpContext.Connection.LocalIpAddress (user IP)", Request.HttpContext.Connection.LocalIpAddress.ToString()));
            headers.Add(new Generic2String("Request.HttpContext.Connection.LocalPort (user TCP port)", Request.HttpContext.Connection.LocalPort.ToString()));
            headers.Add(new Generic2String("Request.HttpContext.Connection.RemoteIpAddress (server IP)", Request.HttpContext.Connection.RemoteIpAddress.ToString()));
            headers.Add(new Generic2String("Request.HttpContext.Connection.RemotePort (server TCP port)", Request.HttpContext.Connection.RemotePort.ToString()));
            headers.Add(new Generic2String("Request.HttpContext.Session.Id", Request.HttpContext.Session.Id.ToString()));
            headers.Add(new Generic2String("Request.IsHttps", Request.IsHttps.ToString()));
            headers.Add(new Generic2String("Request.Method", Request.Method.ToString()));
            headers.Add(new Generic2String("Request.Path", Request.Path.ToString()));
            headers.Add(new Generic2String("Request.Protocol", Request.Protocol.ToString()));
            headers.Add(new Generic2String("Request.QueryString", Request.QueryString.ToString()));
            headers.Add(new Generic2String("Request.Query", Request.Query.ToString()));
            foreach (var item in Request.Query)
            {
                headers.Add(new Generic2String($"Request.Query['{item.Key}']", item.Value));
            }

            return View(headers);
        }



        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
