using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class CheckoutController : Controller
    {
        public MvcMusicStoreContext _context;
        public CheckoutController(MvcMusicStoreContext context)
        {
            _context = context;
        }


        public IActionResult AddressAndPayment()
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;

            ViewBag.provinceCode = new SelectList(
                _context.Province.OrderBy(a => a.Name),
                "ProvinceCode", "Name");
            ViewBag.countryCode = new SelectList(
                 _context.Country.OrderBy(a => a.Name),
                 "CountryCode", "Name");
            return View(order);
        }

        [HttpPost]
        public IActionResult AddressAndPayment(Order order)
        {
            if (ModelState.IsValid)
            {
                TempData["message"] = "valid";
                return Redirect("AddressAndPayment");
            }
            else
                TempData["message"] = ">>>>>>>>>NOT valid<<<<<<<";
            return View(order);
        }


    }
}