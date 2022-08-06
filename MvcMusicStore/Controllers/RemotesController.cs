using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMusicStore.Controllers
{
    public class RemotesController : Controller
    {
        public JsonResult OrderDateNotInFuture(DateTime OrderDate)
        {
            if (OrderDate <= DateTime.Now)
                return Json(true);
            else
                return Json("order date cannot be in the future");
        }

        public JsonResult PostalCodeValidation(string PostalCode)
        {
            if (string.IsNullOrEmpty(PostalCode))
                return Json(true);

            Regex pattern = new Regex(@"^[a-z]\d[a-z] ?\d[a-z]\d$", RegexOptions.IgnoreCase);

            if (pattern.IsMatch(PostalCode))
                return Json(true);
            else
                return Json("postal code does not match the Cdn pattern: A3A 3A3");

        }


    }
}